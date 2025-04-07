using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class RemoveScaleKeyframes : EditorWindow
{
    [MenuItem("GTTOD Mod Tools/Remove Scale Keyframes")]
    [MenuItem("Assets/GTTOD Mod Tools/Remove Scale Keyframes")]
    public static void ShowWindow()
    {
        GetWindow<RemoveScaleKeyframes>("Remove Scale Keyframes");
    }

    private SerializedObject serializedObject;
    private SerializedProperty clipsProperty;

    [SerializeField]
    private List<AnimationClip> clips = new List<AnimationClip>();

    void OnEnable()
    {
        serializedObject = new SerializedObject(this);
        clipsProperty = serializedObject.FindProperty("clips");
        AddSelectedClips();
    }

    void OnGUI()
    {
        GUILayout.Label("Remove Scale Keyframes", EditorStyles.boldLabel);

        serializedObject.Update();
        EditorGUILayout.PropertyField(clipsProperty, true);
        serializedObject.ApplyModifiedProperties();

        if (clips.Count > 0 && GUILayout.Button("Remove Scale Keyframes"))
        {
            foreach (AnimationClip animationClip in clips)
            {
                RemoveScaleKeyframesFromClip(animationClip);
            }
        }
    }

    void AddSelectedClips()
    {
        foreach (var obj in Selection.objects)
        {
            if (obj is AnimationClip clip && !clips.Contains(clip))
            {
                clips.Add(clip);
            }
        }
    }

    void RemoveScaleKeyframesFromClip(AnimationClip clip)
    {
        if (clip == null)
        {
            Debug.LogError("No Animation Clip selected.");
            return;
        }

        EditorCurveBinding[] curveBindings = AnimationUtility.GetCurveBindings(clip);

        List<EditorCurveBinding> scaleBindings = new List<EditorCurveBinding>();

        foreach (var binding in curveBindings)
        {
            if (binding.propertyName.Contains("m_LocalScale"))
            {
                scaleBindings.Add(binding);
            }
        }

        foreach (var binding in scaleBindings)
        {
            AnimationUtility.SetEditorCurve(clip, binding, null);
        }

        Debug.Log("Removed scale keyframes from " + clip.name);
    }
}
