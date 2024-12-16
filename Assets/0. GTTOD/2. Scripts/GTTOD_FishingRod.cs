using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_FishingRod : MonoBehaviour
{
	[Header("OBJECTS")]
	public Transform CameraRoot;

	public Transform RodEnd;

	public Transform LineMidpoint;

	public Rigidbody Bobber;

	public ParticleSystem WaterSplashes;

	public Transform Fish;

	public AnimationFunctions WaterAudio;

	public AudioSource ReelAudio;

	public AudioSource FishAudio;

	public LineRenderer RodLine;

	public LineRenderer FishingLine;

	public CanvasGroup HookingMinigame;

	public CanvasGroup ReelingMinigame;

	[Header("STATS")]
	public float Gravity;

	public float WaterOffset;

	[Header("UI")]
	public Image LeftHealthBar;

	public Image RightHealthBar;

	public Text HealthText;

	public Scrollbar TensionBar;

	public Scrollbar FishBar;

	public RectTransform Ripples;

	public CanvasGroup HookPoint;

	[Header("LISTS")]
	public List<FishingRodSegment> RodSegments;

	public List<AudioClip> SFX;

	public List<Transform> RodPoints;

	public List<Transform> FishingPoints;

	[HideInInspector]
	public GTTOD_FishingSpot FishingSpot;

	private SustainedShake Shake;

	private Animator Anim;

	private Animator RippleAnim;

	private CanvasGroup RippleGroup;

	private Transform LookDirection;

	private Vector3 FishStartingPosition;

	private Vector3 FishDestination;

	private float SmoothStrength;

	private float SmoothReel;

	private float SmoothBend;

	private float SmoothLean;

	private float SmoothPull;

	private float FishSpeed;

	private float FishRestTime;

	private float BarValue;

	private float BarSpeed;

	private float ReelTime;

	private float BiteTime;

	private float LineHealth;

	private float HookTime;

	private int BendMultiplier;

	private int BarDirection;

	private bool Active;

	private bool FishOnHook;

	private bool Reeling;

	private bool InZone;

	private bool Biting;

	private bool HookInLine;

	private bool Casting;

	private bool CanLeave;

	private bool HasHookedFish;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void RodUpdate()
	{
	}

	private void BobberUpdate()
	{
	}

	private void FishUpdate()
	{
	}

	private void CatchUpdate()
	{
	}

	public void CastBobber()
	{
	}

	private void BeginFish()
	{
	}

	public void AlignHook(bool InLine)
	{
	}

	private void StartNibble()
	{
	}

	private void EndNibble()
	{
	}

	private void HookFish()
	{
	}

	public void EndFish()
	{
	}

	public void LeaveFishingSpot()
	{
	}
}
