using UnityEngine;
using UnityEngine.Video;

public class GTTOD_Tutorial : MonoBehaviour
{
	public GTTOD_Reflection Reflection;

	public GTTOD_TheExclusionZone ExclusionZone;

	public Vector2 ActivationRange;

	public Transform Checkpoint;

	[Header("MESSAGE")]
	public string Message;

	public bool VideoTutorial;

	[ConditionalField("VideoTutorial", null)]
	public VideoClip Clip;

	[ConditionalField("VideoTutorial", null)]
	public bool InfoMessage;

	[ConditionalField("InfoMessage", null)]
	public string MessageTopic;

	public bool InputMessage;

	[ConditionalField("InputMessage", null)]
	public int MessageInput;

	[ConditionalField("InputMessage", null)]
	public string MessageEnd;

	public bool Disable;

	private GameManager GM;

	private GTTOD_HUD HUDManager;

	private GTTOD_Manager Manager;

	private Transform Player;

	private string FullMessage;

	private bool TutorialOn;

	private bool TutorialDisabled;

	private void OnDrawGizmosSelected()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
