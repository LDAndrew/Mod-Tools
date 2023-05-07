using System;
using UnityEngine;
using UnityEditor;
using System.IO;
using static System.Environment;

public class CreateAssetBundle : MonoBehaviour
{
    [MenuItem("Assets/GTTOD Mod Tools/Create Asset Bundles")]
    private static void BuildAllAssetBundles()
    {
        string CustomModFolder = @"E:\GTTODMods";
        if (CustomModFolder != @"NOTHING" && Directory.Exists(CustomModFolder))
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
            Directory.CreateDirectory(CustomModFolder);
            Debug.Log("PATH NOT SELECTED");
        }
    }
}