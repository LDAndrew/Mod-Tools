using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTTOD_Interactable : MonoBehaviour
{
    public InteractionSettings Settings;
    [Header("WORLD INTERACTION")]
    [Space(5)]

    public bool Disable;
    public bool ActivateOnDamage = false;
    public bool Cutscene = false;
    [ConditionalField("Cutscene")] public int CutsceneID;
    [ConditionalField("Cutscene")] public Transform CutsceneRoot;
    public bool GearTerminal;
    public bool Spawn;
    public bool Workbench;
    [ConditionalField("Workbench")] public Transform WorkbenchRoot;
    public bool KarmaTablet = false;
    [ConditionalField("KarmaTablet")] public Transform TabletRoot;
    [ConditionalField("KarmaTablet")] public bool Blessing;
    public bool EnduranceCrystal = false;
    public bool CleansingPool = false;
}
[System.Serializable]
public class InteractionSettings
{
    public Color InteractionColor = Color.white;
    public string DescriptionText;
    public string NameText;
    [HideInInspector] public string InputText;
}