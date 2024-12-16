using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GTTOD_Mod))]
public class GTTOD_ModEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GTTOD_Mod mod = (GTTOD_Mod)target;

        if (ModToolsCore.config != null)
        {
            mod.SteamID = ModToolsCore.config.SteamUserID;
        }

        DrawDefaultInspector();
    }
}