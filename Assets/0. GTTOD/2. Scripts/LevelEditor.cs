using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEditor : MonoBehaviour
{
	public static LevelEditor Editor;

	public GameObject EditorUI;

	public GameObject EditorCamera;

	public List<GameObject> Folders;

	[Header("GROUPS")]
	public CanvasGroupExtensions EditorGroup;

	public CanvasGroupExtensions AssetPathDialogue;

	public CanvasGroupExtensions ConfirmDialogue;

	public CanvasGroupExtensions InfoDialogue;

	[Header("TEXTS")]
	public Text InfoText;

	[Header("TOOLS")]
	public GameObject SaveDialogue;

	public InputField FileDialogue;

	public GameObject SaveButton;

	public string AssetPath;

	public string FileName;

	private Transform SpawnLocation;

	private GameObject LastObject;

	private bool HasSelectedName;

	private bool Saving;

	private int FolderNumber;

	private string NewDirectory;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetDirectory(string DirectoryPath)
	{
	}

	public void ApplyDirectory()
	{
	}

	public void CreateDirectory()
	{
	}

	public void SpawnObject(GameObject ObjectToSpawn)
	{
	}

	public void ApplyCanvas(PopUpCanvas MyCanvas, string Subject, float Value)
	{
	}

	public void InformPlayer(string Information)
	{
	}

	public void MoveFolder(bool Right)
	{
	}

	public void EnableEditor()
	{
	}

	public void DisableEditor()
	{
	}

	public void SaveLoadMap_Start(bool Save)
	{
	}

	public void SaveLoadMap_Submit(string SubmittedString)
	{
	}

	public void SaveLoadMap_Apply()
	{
	}

	public bool IsPathValidRootedLocal(string pathString)
	{
		return false;
	}

	public void DeleteSelectedObjects()
	{
	}
}
