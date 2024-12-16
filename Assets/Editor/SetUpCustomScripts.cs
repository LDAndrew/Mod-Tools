using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class SetUpCustomScripts : MonoBehaviour
{
    [InitializeOnLoadMethod]
    public static void OnScriptsReloaded()
    {
        Debug.Log("Scripts reloaded");
        SetUpScripts();
    }

    [MenuItem("Assets/GTTOD Mod Tools/Set Up Custom Scripts")]
    public static void SetUpScripts()
    {
        string sourceDirectory = "Assets/0. GTTOD/0. Mods";
        string[] scriptFiles = Directory.GetFiles(sourceDirectory, "*.cs", SearchOption.AllDirectories);

        foreach (string scriptFile in scriptFiles)
        {
            if (!scriptFile.Contains(".scripts")) continue;

            string directory = Path.GetDirectoryName(scriptFile);
            string assetPath = scriptFile + ".txt";

            bool didFileAlreadyExist = File.Exists(assetPath);

            string scriptContent = File.ReadAllText(scriptFile);
            File.WriteAllText(assetPath, scriptContent);

            if (!didFileAlreadyExist)
            {
                AssetDatabase.ImportAsset(assetPath);
            }

            var modTypeExtensions = new Dictionary<string, string>
            {
                { "thing", ".thing" },
                { "ost", ".ost" },
                { "weapon", ".weapon" },
                { "map", ".map" },
                { "enemy", ".enemy" },
                { "melee", ".melee" },
                { "equipment", ".equipment" },
                { "bundle", ".bundle" }
            };

            string modTypeExtension = null;

            AssetImporter assetImporter = AssetImporter.GetAtPath(assetPath);
            foreach (var file in Directory.GetFiles(directory))
            {
                assetImporter = AssetImporter.GetAtPath(file);
                if (assetImporter == null)
                {
                    continue;
                }

                if (modTypeExtensions.ContainsKey(assetImporter.assetBundleVariant))
                {
                    modTypeExtension = assetImporter.assetBundleVariant;
                    break;
                }
            }

            string parentDirectory = Path.GetDirectoryName(scriptFile).Substring(0, Path.GetDirectoryName(scriptFile).LastIndexOf(Path.DirectorySeparatorChar));
            if (modTypeExtension == null)
            {
                foreach (var file in Directory.GetFiles(parentDirectory))
                {
                    string directoryName = Path.GetDirectoryName(scriptFile).Replace(".scripts", "");
                    directoryName = Path.GetFileName(directoryName);

                    if (!file.Contains(directoryName)) continue;

                    assetImporter = AssetImporter.GetAtPath(file);
                    if (assetImporter == null)
                    {
                        continue;
                    }

                    if (modTypeExtensions.ContainsKey(assetImporter.assetBundleVariant))
                    {
                        modTypeExtension = assetImporter.assetBundleVariant;
                        break;
                    }
                }
            }

            if (modTypeExtension == null)
            {
                string[] modTypes = { "thing", "ost", "weapon", "map", "enemy", "melee", "equipment", "bundle" };
                int selectedModType = ModTypeSelectionWindow.Show(modTypes, directory);

                if (selectedModType == -1)
                {
                    Debug.LogWarning("Mod type selection was canceled.");
                    continue;
                }

                modTypeExtension = modTypes[selectedModType];
            }

            assetImporter = AssetImporter.GetAtPath(assetPath);
            if (assetImporter != null)
            {
                assetImporter.assetBundleName = Path.GetFileNameWithoutExtension(directory);
                assetImporter.assetBundleVariant = modTypeExtension;
            }

            CreateAsmDefFile(directory);
        }

        AssetDatabase.Refresh();
    }

    private static void CreateAsmDefFile(string directory)
    {
        string asmDefPath = Path.Combine(directory, Path.GetFileNameWithoutExtension(directory) + ".asmdef");
        var asmDefContent = new AsmDefContent
        {
            name = Path.GetFileNameWithoutExtension(directory),
            references = new string[0],
            includePlatforms = new string[0],
            excludePlatforms = new string[0],
            allowUnsafeCode = false,
            overrideReferences = true,
            precompiledReferences = new[] { "Assembly-CSharp.dll" },
            autoReferenced = true,
            defineConstraints = new string[0],
            versionDefines = new object[0],
            noEngineReferences = false
        };

        string jsonContent = JsonUtility.ToJson(asmDefContent, true);
        File.WriteAllText(asmDefPath, jsonContent);
    }

    [System.Serializable]
    private class AsmDefContent
    {
        public string name;
        public string[] references;
        public string[] includePlatforms;
        public string[] excludePlatforms;
        public bool allowUnsafeCode;
        public bool overrideReferences;
        public string[] precompiledReferences;
        public bool autoReferenced;
        public string[] defineConstraints;
        public object[] versionDefines;
        public bool noEngineReferences;
    }
}
