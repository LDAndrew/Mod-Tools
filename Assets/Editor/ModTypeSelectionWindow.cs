using UnityEditor;
using UnityEngine;

public class ModTypeSelectionWindow : EditorWindow
{
    private string[] modTypes;
    private string directory;
    private int selectedModTypeIndex = 0;
    private bool selectionMade = false;

    public static int Show(string[] modTypes, string directory)
    {
        ModTypeSelectionWindow window = ScriptableObject.CreateInstance<ModTypeSelectionWindow>();
        window.modTypes = modTypes;
        window.directory = directory;
        window.titleContent = new GUIContent("Select Mod Type");
        window.ShowModal();
        return window.selectionMade ? window.selectedModTypeIndex : -1;
    }

    private void OnGUI()
    {
        GUILayout.Label($"Please select the mod type for the scripts folder: {directory}", EditorStyles.wordWrappedLabel);
        selectedModTypeIndex = EditorGUILayout.Popup("Mod Type", selectedModTypeIndex, modTypes);

        GUILayout.Space(20);

        if (GUILayout.Button("OK"))
        {
            selectionMade = true;
            Close();
        }

        if (GUILayout.Button("Cancel"))
        {
            selectionMade = false;
            Close();
        }
    }
}
