using UnityEngine;
using UnityEditor;

public class FBXImportPostprocessor : AssetPostprocessor
{
    void OnPreprocessModel()
    {
        if (assetPath.EndsWith(".fbx", System.StringComparison.OrdinalIgnoreCase))
        {
            ModelImporter modelImporter = (ModelImporter)assetImporter;
            modelImporter.animationCompression = ModelImporterAnimationCompression.Off;
            modelImporter.isReadable = true;
        }
    }
}
