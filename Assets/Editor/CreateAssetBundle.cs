using System;
using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateAssetBundle : MonoBehaviour
{
    [MenuItem("Assets/GTTOD Mod Tools/Create Asset Bundles")]
    private static void BuildAllAssetBundles()
    {
        string CustomModFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Get To The Orange Door\mods";

        if (!Directory.Exists(CustomModFolder))
        {
            Directory.CreateDirectory(CustomModFolder);
        }

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
            Debug.Log("PATH NOT SELECTED");
        }
    }
}