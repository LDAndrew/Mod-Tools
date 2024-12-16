using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Microsoft.Win32;
using System.IO;
using UnityEditor.SceneManagement;

public class FirstTimeSetupWindow : EditorWindow
{
    private int currentPage = 0;

    [MenuItem("GTTOD Mod Tools/First Time Setup")]
    public static void BeginSetup()
    {
        //open scene
        EditorSceneManager.OpenScene("Assets/0. GTTOD/1. Scenes/GTTODMods/GTTODMods.unity");

        FirstTimeSetupWindow window = EditorWindow.GetWindow<FirstTimeSetupWindow>();
        window.titleContent = new GUIContent("First Time Setup");
        window.position = new Rect((Screen.width - 700) / 2, (Screen.height - 400) / 2, 700, 400);
        window.Show();
    }

    public void OnGUI()
    {
        switch (currentPage)
        {
            case 0:
                DrawPage1();
                break;
            case 1:
                DrawPage2();
                break;
            case 2:
                DrawPage3();
                break;
            case 3:
                DrawPage4();
                break;
            case 4:
                DrawPage5();
                break;
            case 5:
                DrawPage6();
                break;
        }

        GUILayout.FlexibleSpace();
        GUILayout.BeginHorizontal();
        if (currentPage > 0)
        {
            if (GUILayout.Button("Back"))
            {
                currentPage--;
            }
        }
        GUILayout.FlexibleSpace();
        if (currentPage < 5)
        {
            if (GUILayout.Button("Next"))
            {
                currentPage++;
            }
        }
        else
        {
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Finish"))
            {
                ModToolsCore.config.FirstTime = true;
                ModToolsCore.SaveConfig();
                Close();
            }
        }
        GUILayout.EndHorizontal();
    }

    private void DrawPage1()
    {
        GUIStyle largeTextStyle = new GUIStyle(GUI.skin.label);
        largeTextStyle.fontSize = 24;
        largeTextStyle.wordWrap = true;
        largeTextStyle.alignment = TextAnchor.MiddleCenter;

        GUILayout.Label("Welcome to the GTTOD Mod Tools!", largeTextStyle);
        GUILayout.Label("This is the setup for the modding tools, this setup tool will get everything ready for you.", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage2()
    {
        GUILayout.Label("Please enter the folder where GTTOD is installed.", EditorStyles.wordWrappedLabel);
        ModToolsCore.config.GameFolder = EditorGUILayout.TextField("Game Folder", ModToolsCore.config.GameFolder);

        GUILayout.Space(20);

        GUILayout.Label("Please enter the folder where your mods will be stored.", EditorStyles.wordWrappedLabel);
        ModToolsCore.config.ModFolder = EditorGUILayout.TextField("Mod Folder", ModToolsCore.config.ModFolder);
    }

    private void DrawPage3()
    {
        if (!File.Exists(ModToolsCore.config.GameFolder + "\\Get To The Orange Door.exe"))
        {
            GUILayout.Label("The game executable was not found in the specified folder!", EditorStyles.wordWrappedLabel);
            GUILayout.Label("Please go back and enter the correct path.", EditorStyles.wordWrappedLabel);
            return;
        }

        GUILayout.Label("Updating Game Settings...", EditorStyles.wordWrappedLabel);

        string keyPath = @"SOFTWARE\Layers Deep\Get To The Orange Door";
        string valueName = "CustomModPath_h1699865757";
        string modFolderPath = ModToolsCore.config.ModFolder;

        try
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
            {
                if (key != null)
                {
                    key.SetValue(valueName, modFolderPath, RegistryValueKind.String);
                    GUILayout.Label("Settings updated successfully.", EditorStyles.wordWrappedLabel);
                }
                else
                {
                    GUILayout.Label("Failed to open registry key.", EditorStyles.wordWrappedLabel);
                }
            }
        }
        catch (System.Exception ex)
        {
            GUILayout.Label($"Error updating settings: {ex.Message}", EditorStyles.wordWrappedLabel);
        }
    }

    private void DrawPage4()
    {
        GUILayout.Label("Please enter your Steam User ID.", EditorStyles.wordWrappedLabel);
        ModToolsCore.config.SteamUserID = EditorGUILayout.TextField("Steam User ID", ModToolsCore.config.SteamUserID);

        GUILayout.Space(20);
        GUILayout.Label("You can find your Steam ID by...", EditorStyles.wordWrappedLabel);
        GUILayout.Label("1. Opening the game via Steam", EditorStyles.wordWrappedLabel);
        GUILayout.Label("2. Starting or continuing a run/starting Quick Play", EditorStyles.wordWrappedLabel);
        GUILayout.Label("3. Going to the key bindings, scrolling all the way down and binding the dev console to a key", EditorStyles.wordWrappedLabel);
        GUILayout.Label("4. Pressing the key you bound to the dev console and typing in \"steamid\" and pressing enter", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage5()
    {
        GUILayout.Label("Would you like to install some BepInEx plugins that will help with modding?", EditorStyles.wordWrappedLabel);
        GUILayout.Label("The plugins will give you access to the \"reload\" console command to reload mods, the ability to equip guns (including mod guns) using the name of the gun instead of the id, a console window for debugging, and access to debug tools by pressing F7.", EditorStyles.wordWrappedLabel);

        GUILayout.Space(20);

        if (GUILayout.Button("Install Plugins"))
        {
            System.IO.Compression.ZipFile.ExtractToDirectory("Assets/0. GTTOD/9. Tools/Plugins.zip", ModToolsCore.config.GameFolder, true);
            currentPage++;
        }
        if (GUILayout.Button("Skip"))
        {
            currentPage++;
        }
    }

    private void DrawPage6()
    {
        GUILayout.Label("That's all for the basic setup! Now it is time to start making a mod.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("There are tutorials available under the tutorials tab in top bar.", EditorStyles.wordWrappedLabel);
    }
}
