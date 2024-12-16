using System.Collections.Generic;
using UnityEngine;

public class GTTOD_CardPack : MonoBehaviour
{
	public Transform GrabPoint;

	public AudioSource TearAudio;

	public List<Transform> TearPoints;

	private ac_CharacterController CharacterController;

	private GTTOD_GearCardManager GearCardManager;

	private Camera MainCamera;

	private Animator Anim;

	private bool Tearing;

	private bool Torn;

	private float TearProgress;

	private int LastIndex;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Unlock()
	{
	}

	public void Return()
	{
	}
}
