using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordPlayer : MonoBehaviour
{
	public QuickDirtyRotate Record;

	public QuickDirtyRotate Crank;

	public CanvasGroup Alpha;

	public Text PatronNameText;

	public float ShowTime;

	[Space(15f)]
	public List<string> Patrons;

	private AudioSource Audio;

	private Animator Anim;

	private bool Fading;

	private bool Active;

	private int PatronIndex;

	private float TimeActive;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartCrank()
	{
	}

	public void NewPatron()
	{
	}
}
