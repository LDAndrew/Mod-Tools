using System;
using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateAssetBundle : MonoBehaviour
{
    [MenuItem("GTTOD Mod Tools/Create Asset Bundles")]
    [MenuItem("Assets/GTTOD Mod Tools/Create Asset Bundles")]
    private static void BuildAllAssetBundles()
    {
        string CustomModFolder = ModToolsCore.config.ModFolder;

        if (!Directory.Exists(CustomModFolder))
        {
            Directory.CreateDirectory(CustomModFolder);
        }

        if (Directory.Exists(CustomModFolder))
        {
            try
            {
                BuildPipeline.BuildAssetBundles(CustomModFolder, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
            }
            catch (Exception Error)
            {
                Debug.LogError(Error);
            }
        }
        else
        {
            Debug.LogError("Custom mods folder doesn't exist!");
        }
    }
}