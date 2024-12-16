using UnityEngine;
using UnityEditor;
using System.IO;

public class ModToolsCore : MonoBehaviour
{
    public static Config config;

    [InitializeOnLoadMethod]
    public static void Initialize()
    {
        EditorApplication.delayCall += Load;
    }

    public static void Load()
    {
        config = LoadConfig();

        if (!config.FirstTime)
        {
            FirstTimeSetupWindow.BeginSetup();
        }
    }

    public static Config LoadConfig()
    {
        string configPath = "Assets/Config.json";
        if (!File.Exists(configPath))
        {
            config = new Config();
            SaveConfig();
        }
        else
        {
            string configJson = File.ReadAllText(configPath);
            config = JsonUtility.FromJson<Config>(configJson);
        }

        return config;
    }

    public static void SaveConfig()
    {
        string configPath = "Assets/Config.json";
        string configJson = JsonUtility.ToJson(config, true);
        File.WriteAllText(configPath, configJson);
    }
}

public class Config
{
    public bool FirstTime = false;
    public string GameFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Get To The Orange Door\";
    public string ModFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Get To The Orange Door\mods\";
    public string SteamUserID = "Enter Steam ID here";
}
