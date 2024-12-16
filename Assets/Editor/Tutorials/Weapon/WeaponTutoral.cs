using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class WeaponTutorial : EditorWindow
{
    private int currentPage = 0;
    
    [MenuItem("Tutorials/Basic Weapon Mod")]
    public static void BeginSetup()
    {
        WeaponTutorial window = EditorWindow.GetWindow<WeaponTutorial>();
        window.titleContent = new GUIContent("Weapon Mod Tutorial");
        window.position = new Rect((Screen.width - 600) / 2, (Screen.height - 800) / 2, 600, 800);
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
            case 6:
                DrawPage7();
                break;
            case 7:
                DrawPage8();
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
        if (currentPage < 7)
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

        GUILayout.Label("Welcome to the Weapon Mod Tutorial", largeTextStyle);
        GUILayout.Space(20);
        GUILayout.Label("This tutorial will guide you through the process of implementing a weapon mod.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("This does not cover using 3D modeling software such as Blender. It is assumed that you already have an FBX file for your weapon.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("This tutorial is not designed for guns with multistage reloads (things like the standard shotgun or the bolt action from the game).", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage2()
    {
        GUIStyle largeTextStyle = new GUIStyle(GUI.skin.label);
        largeTextStyle.fontSize = 24;
        largeTextStyle.wordWrap = true;
        largeTextStyle.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Setting up the FBX", largeTextStyle);
        GUILayout.Space(20);
        GUILayout.Label("Open the Assets/0. GTTOD/0. Mods/1. WeaponMods directory.", EditorStyles.wordWrappedLabel);
        if (GUILayout.Button("Show Weapon Mods Folder"))
        {
            string folderPath = "Assets/0. GTTOD/0. Mods/1. WeaponMods";
            Object folder = AssetDatabase.LoadAssetAtPath<Object>(folderPath);
            if (folder != null)
            {
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = folder;
            }
            else
            {
                Debug.LogError("Weapon Mods folder not found at path: " + folderPath);
            }
        }
        GUILayout.Label("Then create a new folder for your mod (right click -> create -> folder and name it.", EditorStyles.wordWrappedLabel);

        GUILayout.Space(20);

        GUILayout.Label("Take you FBX file and drag it into that folder.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Click on that FBX file and under the Model tab enable \"Read/Write\".", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Then click on the Animation tab and disable animation compression using the dropdown.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Then click on the Materials tab and use the materials from the \"Assets/0. GTTOD/5. Materials\" folder to add the materials.", EditorStyles.wordWrappedLabel);
        if (GUILayout.Button("Show Materials Folder"))
        {
            string folderPath = "Assets/0. GTTOD/5. Materials";
            Object folder = AssetDatabase.LoadAssetAtPath<Object>(folderPath);
            if (folder != null)
            {
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = folder;
            }
            else
            {
                Debug.LogError("Materials folder not found at path: " + folderPath);
            }
        }
        GUILayout.Label("When you are done press apply.", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage3()
    {
        GUIStyle largeTextStyle = new GUIStyle(GUI.skin.label);
        largeTextStyle.fontSize = 24;
        largeTextStyle.wordWrap = true;
        largeTextStyle.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Setting up the animation controller", largeTextStyle);
        GUILayout.Space(20);
        GUILayout.Label("Make a new folder in weapons folder, it will be for animations.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Press the arrow on the right of the fbx file and copy them into that folder. You can delete any animations you don't need", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Make a copy of the Template animation controller and put the copy into the same folder.", EditorStyles.wordWrappedLabel);
        if (GUILayout.Button("Show Template Controller"))
        {
            string folderPath = "Assets/0. GTTOD/0. Mods/1. WeaponMods/Template.controller";
            Object folder = AssetDatabase.LoadAssetAtPath<Object>(folderPath);
            if (folder != null)
            {
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = folder;
            }
            else
            {
                Debug.LogError("Template Animation Controller not found at path: " + folderPath);
            }
        }

        GUILayout.Space(20);

        GUILayout.Label("Click on the controller and open the Animator panel.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("On the primary layer you will see the animation states. Click on one of the states and look in the top right of the panel. If it says \"None\" then simply drag the animation for that state into the slot. If it does not say None then you will need to double click the state to open it's Blend Tree. With the blend tree open you can assign the states dependent on how much ammo is left in the gun. You do not need to assign sprint, reload insert/end, and charge for most guns.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("If you have more than one fire mode then you can create a new layer and copy the states from the primary layer. If the different fire modes have different animations then change the animations on the new layer.", EditorStyles.wordWrappedLabel);
        GUILayout.Space(20);
        GUILayout.Label("Make sure that the Rest state has an animation. The animation should be 1 frame long and all of the bones should be keys to your guns resting position.", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage4()
    {
        GUIStyle largeTextStyle = new GUIStyle(GUI.skin.label);
        largeTextStyle.fontSize = 24;
        largeTextStyle.wordWrap = true;
        largeTextStyle.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Setting up the Weapon", largeTextStyle);
        GUILayout.Space(20);
        GUILayout.Label("Open the Sway Parent. There is a coinvent button on the GTTOD_Mods game object in the hierarchy.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Drag the weapon model into the Sway Parent.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Make sure that the materials you set in the FBX were correct, if they were not then change them there.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Once the materials look correct right click it and under prefab press unpack.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Delete any objects you don't need, this includes any cameras, lights, random meshes or whatever. Leave the gun mesh, rig, and anything else you need.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Go to the \"Assets/0. GTTOD/8. ModPrefabs/WeaponBase\" folder and drag the \"Weapon\" prefab into the Sway Parent. Unpack the prefab and then select and drag all of the objects that are a child of the FBX file to unpacked Weapon object. Delete the original object. You should have one object with a WeaponScript and multiple direct children after completing this step.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Take the other 2 files in the WeaponBase folder and copy them into your weapon's folder. You will need them later.", EditorStyles.wordWrappedLabel);
        if (GUILayout.Button("Show Weapon Prefab"))
        {
            string folderPath = "Assets/0. GTTOD/8. ModPrefabs/WeaponBase/Weapon.prefab";
            Object folder = AssetDatabase.LoadAssetAtPath<Object>(folderPath);
            if (folder != null)
            {
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = folder;
            }
            else
            {
                Debug.LogError("WeaponBase folder not found at path: " + folderPath);
            }
        }
        GUILayout.Label("Click on your weapon object and then go to Layer in the top right of the inspector. Set the layer to \"Weapon\".", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Take the scale parameter and set it to 3 for the X, Y, and Z axis.", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage5()
    {
        GUIStyle largeTextStyle = new GUIStyle(GUI.skin.label);
        largeTextStyle.fontSize = 24;
        largeTextStyle.wordWrap = true;
        largeTextStyle.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Setting up the Animation Events", largeTextStyle);
        GUILayout.Space(20);
        GUILayout.Label("Go back to the folder that had all of your animation controller and drag the controller into the \"Runtime Animation Controller\" field on the Animator component of the weapon object.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("With your gun still selected in the hierarchy go to the Animation tab. There will be a drop down with all the animations for your weapon. You need to add some events to your animations so that they work correctly in game.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("You can add an animation event by moving the play head to the time you want the event to happen and then pressing the \"Add Event\" button. This button is located right under the frame number and has a plus sign on it. Once the event is added go back to the inspector tab to configure it. There will be a Function drop down. When clicked you will have a WeaponScript and AnimationFunctions option. Under each of those you can see the list of methods. You can pick one and then that method will run when that point in the animation is reached.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("You need the following WeaponScript events:", EditorStyles.wordWrappedLabel);
        GUILayout.Label("DrawEnd - This is at the last frame of the draw animation.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("TransitionEnd - This is at the last frame of the transition animation.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("ReloadIncreaseAmmo - This is the frame where the magazine is inserted into the gun. It takes a number, setting it to 1000000 will do the trick in most cases.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("ReloadEnd - This is the last frame of the reload animation.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("InspectEnd - This is the last frame of the inspect animation.", EditorStyles.wordWrappedLabel);
        GUILayout.Space(20);
        GUILayout.Label("There is also a ReloadDetail event, this can be used during the inspect animation to alter the ammo count if you have the view model remove the mag or eject a bullet.\nReloadDetails takes a string as an input, valid stings are: EjectShell, RemoveMagazine, ChamberRound, and InsertMagazine.", EditorStyles.wordWrappedLabel);
        GUILayout.Space(20);
        GUILayout.Label("AnimationFunctions also provides some events for you to use, none of them are required:", EditorStyles.wordWrappedLabel);
        GUILayout.Label("The shakes - Shakes the camera.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("PlayLocalSoundEffect - Plays a sound that ends if you switch off the gun.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("PlaySoundEffect - Plays a sound that continues even if you switch off the gun.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("PlayVisualEffect - Starts a particle system.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Most of these take a number, the number is determined by the AnimationFunctions script that is attached to the weapon object. You can add your own sounds and visual effects to the to script and then play them using these functions. The numbers start counting at 0. So the first sound or effect in the list would be ID 0, the second one would be ID 1 and so on.", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage6()
    {
        GUIStyle largeTextStyle = new GUIStyle(GUI.skin.label);
        largeTextStyle.fontSize = 24;
        largeTextStyle.wordWrap = true;
        largeTextStyle.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Setting up the Sounds and VFX", largeTextStyle);
        GUILayout.Space(20);
        GUILayout.Label("Sounds", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Make a new Sounds folder in your weapon's folder, and drag and drop all of the sounds for your weapon into that folder.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("In the inspector for your weapon, scroll down to the Animation Functions script. Click on the SFX drop down and press the + button. Set the SFX Handle to the name of the sound, the Chance To Play to 100 (for most sounds), the SFX Volume to 100, the SFX Range to 1 for both the X and Y (unless it's a fire sound then use 0.8 and 1.2). Then click the SXF drop down and press the +. Drag the Audio Clip (sound file) from it's folder into the spot. If you add more than 1 sound the game will randomly pick a sound to play from that list.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Once you add all of your sounds go back to the animations and add animation events to play them. You should use PlaySoundEffect for fire sounds and PlayLocalSoundEffect for most other things. Although you can only have 1 local sound effect playing at once.", EditorStyles.wordWrappedLabel);
        GUILayout.Space(20);
        GUILayout.Label("VFX", EditorStyles.wordWrappedLabel);
        GUILayout.Label("There are 2 effects that you will probably want on your weapon. The muzzle flash (this includes a casing eject) and the BABE effects on the BABE+ version. Both of them can be found in the \"Assets/0. GTTOD/8. ModPrefabs/ParticleEffects\" folder.", EditorStyles.wordWrappedLabel);
        if (GUILayout.Button("Show Particle Effects Folder"))
        {
            string folderPath = "Assets/0. GTTOD/8. ModPrefabs/ParticleEffects/MuzzleFlash.prefab";
            Object folder = AssetDatabase.LoadAssetAtPath<Object>(folderPath);
            if (folder != null)
            {
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = folder;
            }
            else
            {
                Debug.LogError("Particle Effects folder not found at path: " + folderPath);
            }
        }
        GUILayout.Label("Drag the muzzle flash into the gun. Make sure that it is a child of the gun in the gun rig, so that it moves with the gun correctly. Unpack it's prefab and move/rotate it using the gizmos. If you click a child you can move it separately. You can change the active gizmo with toolbar to the left of the scene view. You can press the play button in the bottom right to see what the effect looks like. If you want to change the model for the casing ejection you should click on it's game object and then scroll down in the inspector window. You will see a renderer dropdown, expand it and then change the mesh property to another mesh in the \"Assets/0. GTTOD/3. Art/Particles/\" folder. You can click on the arrow next the mesh you want and then drag the mesh from the popout onto the mesh parameter.", EditorStyles.wordWrappedLabel);
        if (GUILayout.Button("Show Particle Meshes Folder"))
        {
            string folderPath = "Assets/0. GTTOD/3. Art/Particles/Particle_Shell 2.fbx";
            Object folder = AssetDatabase.LoadAssetAtPath<Object>(folderPath);
            if (folder != null)
            {
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = folder;
            }
            else
            {
                Debug.LogError("Particle Meshes folder not found at path: " + folderPath);
            }
        }
        GUILayout.Label("Add the visual effect to the Animation Functions script. The effect is the same as the sound, just drag it into the VFX list and hook up the animation event so it plays when you shoot.", EditorStyles.wordWrappedLabel);

        GUILayout.Label("The BABE+ effect is the same, just drag it onto the gun in the rig. It will play all the time so you don't need to make an event for it.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("To make the BABE+ effect on play on the BABE+ version of the gun drag the game object for the effect into the Upgrade Object parameter on the WeaponScript.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Do not add the BABE+ effect to the generic version of the gun.", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage7()
    {
        GUIStyle largeTextStyle = new GUIStyle(GUI.skin.label);
        largeTextStyle.fontSize = 24;
        largeTextStyle.wordWrap = true;
        largeTextStyle.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Setting up the Weapon Script", largeTextStyle);
        GUILayout.Space(20);
        GUILayout.Label("Open the WeaponScript in the weapon's folder. You will see a bunch of parameters that you can change. These parameters have tooltips to tell you what they do, just hover over the text to look if the name is confusing. Create 1 fire mode using the plus button for each layer on you animation controller excluding the base layer. The weapon should already have 1 fire mode created for you with some basic configuration. Configure the stats to your liking. You do not need to use reload types for most guns.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Once you think you have everything set up you can enter play mode by pressing the play button at the top of the screen. If you have errors they will show up in the console.", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Everything should work in the editor like it does in-game, you can shoot (left click), change fire modes (right-click), reload (r), inspect (i), and crouch (left-control).", EditorStyles.wordWrappedLabel);
        GUILayout.Label("Please note that any changes you make in play mode will be lost when you exit play mode. If you want to save changes to have to exit play mode first.", EditorStyles.wordWrappedLabel);
    }

    private void DrawPage8()
    {
        string command = File.Exists(ModToolsCore.config.GameFolder + "\\BepInEx\\plugins\\MoreCommands.dll") ? "white <weapon name>" : "white <weapon id>";

        GUIStyle largeTextStyle = new GUIStyle(GUI.skin.label);
        largeTextStyle.fontSize = 24;
        largeTextStyle.wordWrap = true;
        largeTextStyle.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Setting up the Pickup and Mod Object", largeTextStyle);
        GUILayout.Space(20);
        GUILayout.Label("You only make one of these for both the normal and BABE versions of your gun.");
        GUILayout.Label("The pickup object is the gun that gets dropped on the ground. You copied it into your weapon folder in an earlier step. Double click it to open it in prefab mode. Then click on the mesh game object. Go to you gun FBX and click on the arrow. In the popout menu find the gun mesh and add it to the Mesh parameter of the Mesh Renderer. If you can't see the gun try to scale it up. When scaling try to get it to fit within the box collider. Once you have it close go to the box collider settings on the root object and make it closer match the weapon size. Also set the weapon name to the name of the generic version of the weapon (all caps).", EditorStyles.wordWrappedLabel);
        GUILayout.Label($"The mod object is the object the game uses to load your mod. It is called weaponname.weapon by default. Start by renaming it to the nameofyourweapon.weapon (all lowercase). In the inspector there is an asset labels section. For asset bundle change the first value to the file name (without the .weapon) and for the second value change it to weapon. You can do that by clicking on None then pressing New.\nThen you will need to drag your gun from the swap parent into the folder. That will turn it into a prefab. You then need to click on the prefab and disable it using the checkbox in the top left corner of the inspector. Click back onto the mod object and drag your prefab into the generic or special weapon depending on if it's the normal or babe version. If you don't have a babe version disable Has Special. Drag the pickup from earlier into the pickup parameter. You also need an icon for the gun, this is for the inventory and hud. To get the icon drag your icon into the weapons folder and then click on it. Change the Texture Type to Sprite (2D and UI) using the dropdown and press apply. Then drag the texture into the icon parameter of the mod object. Now set the name for the generic and special versions (all caps same as the weapon name). For the Workshop settings give it a name, description, thumbnail. The thumbnail should be under 2 megabytes, you can compress the image in Unity via the import settings. Once everything is said and done you can right click anywhere in the project tab and press Create Asset Bundles. Then launch the game use the dev console to equip it ({command})", EditorStyles.wordWrappedLabel);
    }
}
