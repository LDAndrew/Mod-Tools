using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GTTOD_HUD : MonoBehaviour
{
	[Header("GENERAL UI")]
	public List<Image> DisplayLines;

	public List<AudioClip> HUDSFX;

	public bool ShowGeneralUI;

	[ConditionalField("ShowGeneralUI", null)]
	public AudioSource HUDAudio;

	[ConditionalField("ShowGeneralUI", null)]
	public Transform HUD;

	[ConditionalField("ShowGeneralUI", null)]
	public CanvasGroup Scope;

	[ConditionalField("ShowGeneralUI", null)]
	public CanvasGroup LoadGroup;

	[ConditionalField("ShowGeneralUI", null)]
	public CanvasGroup FadeGroup;

	[ConditionalField("ShowGeneralUI", null)]
	public CanvasGroup HUDOpacity;

	[ConditionalField("ShowGeneralUI", null)]
	public CanvasGroup HeatEffects;

	[ConditionalField("ShowGeneralUI", null)]
	public CanvasGroup DamageEffects;

	[ConditionalField("ShowGeneralUI", null)]
	public CanvasGroup WaypointParent;

	[ConditionalField("ShowGeneralUI", null)]
	public RectTransform EnemyHealth;

	[ConditionalField("ShowGeneralUI", null)]
	public Image EnemyHealthBar;

	[ConditionalField("ShowGeneralUI", null)]
	public Image EnemyHealthBarBackground;

	[ConditionalField("ShowGeneralUI", null)]
	public Text EnemyNameText;

	[ConditionalField("ShowGeneralUI", null)]
	public RectTransform DisplayRoot;

	[ConditionalField("ShowGeneralUI", null)]
	public Text DisplayTopText;

	[ConditionalField("ShowGeneralUI", null)]
	public Text DisplayCenterText;

	[ConditionalField("ShowGeneralUI", null)]
	public Text DisplayBottomText;

	[ConditionalField("ShowGeneralUI", null)]
	public CanvasGroup RewardsGroup;

	[ConditionalField("ShowGeneralUI", null)]
	public HorizontalLayoutGroup RewardsContent;

	[ConditionalField("ShowGeneralUI", null)]
	public Text RewardName;

	[ConditionalField("ShowGeneralUI", null)]
	public Text RewardDescription;

	[ConditionalField("ShowGeneralUI", null)]
	public Image DashPointIndicator;

	[ConditionalField("ShowGeneralUI", null)]
	public Transform DashPointRing;

	[Header("ASPECT UI")]
	public bool ShowAspectUI;

	[ConditionalField("ShowAspectUI", null)]
	public CanvasGroup AspectGroup;

	[ConditionalField("ShowAspectUI", null)]
	public CanvasGroup AspectEffectsGroup;

	[ConditionalField("ShowAspectUI", null)]
	public GTTOD_AspectUI AspectUIObject;

	[ConditionalField("ShowAspectUI", null)]
	public RectTransform AspectContent;

	[ConditionalField("ShowAspectUI", null)]
	public Slider AspectContentSlider;

	[ConditionalField("ShowAspectUI", null)]
	public Sprite DefaultRewardIcon;

	[ConditionalField("ShowAspectUI", null)]
	public Sprite MaxedRewardIcon;

	[ConditionalField("ShowAspectUI", null)]
	public Image AspectProgressBar;

	[ConditionalField("ShowAspectUI", null)]
	public Image AspectRewardIcon;

	[ConditionalField("ShowAspectUI", null)]
	public Text AspectProgression;

	[ConditionalField("ShowAspectUI", null)]
	public Text AspectRightPlateText;

	[ConditionalField("ShowAspectUI", null)]
	public Text AspectRightPlateSubtext;

	[ConditionalField("ShowAspectUI", null)]
	public Text AspectLeftPlateText;

	[ConditionalField("ShowAspectUI", null)]
	public Text AspectLeftPlateSubtext;

	[ConditionalField("ShowAspectUI", null)]
	public Text AspectJadeVines;

	[ConditionalField("ShowAspectUI", null)]
	public Text RankDescription;

	[ConditionalField("ShowAspectUI", null)]
	public Text AspectLevel;

	[ConditionalField("ShowAspectUI", null)]
	public Image RankIcon;

	[Header("UPPER UI AND INSTANCED OBJECTS")]
	public List<Image> HealthBars;

	public List<Image> ShieldBars;

	public List<Image> UltimateBars;

	public List<Image> BossHealthBars;

	public List<Image> OvershieldBars;

	public List<Image> ShieldFollowers;

	public List<Text> HealthTexts;

	public List<Text> ShieldTexts;

	public List<GameObject> HealthObjects;

	public bool ShowUpperUIAndInstancedObjects;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public GameObject UpperUI;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public Transform DashIconParent;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public RawImage Compass;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public GameObject BossHealthParent;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public Text BossText;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public Image DashIcon;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public GameObject CompassIcon;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public GTTOD_PopUpText PopUpText;

	[ConditionalField("ShowUpperUIAndInstancedObjects", null)]
	public GTTOD_PopUpText GlobalPopUpText;

	[Header("RETICLE AND INVENTORY UI")]
	public List<CrosshairSegment> CrosshairSegments;

	public List<Hitmarker> Hitmarkers;

	public bool ShowReticleAndInventoryUI;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public float ExtraWeaponSpacing;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public float WeaponBackgroundHeight;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public GameObject InventoryObject;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public RectTransform Reticle;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text ReticleAmmo;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Image HeatGuage;

	[Space(15f)]
	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public RectTransform WeaponBackground;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Image AmmoLine;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Image CurrentWeaponIcon;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text WeaponText;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text CurrentAmmoCounter;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text ReserveAmmoCounter;

	[Space(15f)]
	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public GameObject LethalObject;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public GameObject TacticalObject;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Image LethalFill;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Image TacticalFill;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Image LethalBackground;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Image TacticalBackground;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text LethalCounter;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text TacticalCounter;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text LethalPrompt;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text TacticalPrompt;

	[Space(15f)]
	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text LivesCounter;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text ShardsCounter;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text KeysCounter;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text VinesCounter;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text DefinitionName;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public Text DefinitionDescription;

	[ConditionalField("ShowReticleAndInventoryUI", null)]
	public CanvasGroup DefinitionGroup;

	[Header("MESSAGING AND TUTORIAL UI")]
	public List<Image> SpeedLines;

	public List<Image> TimerLines;

	public bool ShowMessagingAndTutorialUI;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public CanvasGroup StatusEffectsObject;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public GameObject SubtitlesObject;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Transform PopUpContent;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Transform PopUpCenterContent;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Transform GlobalPopUpContent;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public CanvasGroup SubtitleGroup;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Text SubtitleText;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public CanvasGroup BigTextGroup;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Text BigTextText;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public GameObject TutorialObject;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Text TutorialText;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public VideoPlayer VideoTutorialScreen;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public GameObject VideoTutorialObject;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public GameObject VideoTutorialUI;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Text VideoTutorialText;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public GameObject InformationObject;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Text InformationTitleText;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Text InformationDescriptionText;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public GameObject Speedometer;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Text SpeedText;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public GameObject TimerObject;

	[ConditionalField("ShowMessagingAndTutorialUI", null)]
	public Text TimerText;

	[HideInInspector]
	public Aimer AimPoint;

	[HideInInspector]
	public float HeatAddition;

	[HideInInspector]
	public bool HUDHidden;

	[HideInInspector]
	public bool Scanning;

	[HideInInspector]
	public bool UseDamageNumbers;

	[HideInInspector]
	public bool InInfo;

	[HideInInspector]
	public List<Image> DashIcons;

	[HideInInspector]
	public List<GTTOD_ScanObject> ScanObjects;

	private ac_OptionsMenu OptionsMenu;

	private GTTOD_GearCardManager GearCards;

	private ac_ObjectPool ObjectPool;

	private GTTOD_AIManager AIManager;

	private ac_CharacterController CharacterController;

	private GTTOD_Inventory GTTODInventory;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_HealthScript Health;

	private InventoryScript Inventory;

	private ac_CutsceneManager Cutscenes;

	private PlayerEffects Effects;

	private Transform Player;

	private Transform EnemyHealthPosition;

	private Vector3 DefaultDisplayPosition;

	private Vector3 PreviousPosition;

	private Camera MainCamera;

	private Animator ReticleAnimator;

	private Image AspectEffectsVignette;

	private float TimeScale;

	private float RandomX;

	private float RandomY;

	private float ReticleResetTime;

	private float SpreadModifier;

	private float BigTextTimer;

	private float HealthBarHideTime;

	private float HealthAmount;

	private float ShieldAmount;

	private float OvershieldAmount;

	private float HitSFXTime;

	private float VelocityTickRate;

	private float AdjustedVelocity;

	private float SubtitleTime;

	private float CompassUnit;

	private float TimeLine;

	private float RingScale;

	private float FadeAmount;

	private bool ScopeOn;

	private bool DisplayActive;

	private bool FillingBossBar;

	private int TimeElapsed;

	private void Start()
	{
	}

	public void SetUpHUD()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void BumpUpgradeVignette(float BumpAmount, Color BumpColor)
	{
	}

	private void UpdateReticleAndInventoryUI()
	{
	}

	private void UpdateUpperUIAndEnemyHealth()
	{
	}

	private void UpdateMessagingAndSpeedStats()
	{
	}

	public void UpdateHealthUI(float HealthFill, float ShieldFill, float OvershieldFill, string ShieldCount, string HealthCount)
	{
	}

	private void UpdateCompass()
	{
	}

	public void Fire(float Inaccuracy, float Magnitude)
	{
	}

	public void AddScanObject(GTTOD_ScanObject ScanObject)
	{
	}

	public void ClearCompass()
	{
	}

	private Vector2 GetCompassPosition(GTTOD_ScanObject ScanObject)
	{
		return default(Vector2);
	}

	public void SetPickupDisplay(bool Active, string TopText, string MidText, string BottomText, Color LineColor, Vector3 PickupPosition)
	{
	}

	public void AdjustWeaponInformation(Sprite WeaponIcon, string WeaponName, string CurrentAmmo, string ReserveAmmo, float FillAmount, bool OffhandDualWield)
	{
	}

	public void AdjustEquipmentInformation(bool Lethal, Sprite EquipmentIcon, string EquipmentCount, float FillAmount)
	{
	}

	public void AdjustBossHealth(bool Active, float Fill, string BossName)
	{
	}

	public void AdjustDashIcons()
	{
	}

	public void BigTextPopUp(string Message, int AudioClipIndex)
	{
	}

	public void CornerPopUp(string Message, int AudioClipIndex)
	{
	}

	public void CornerPopUp(string Message, int AudioClipIndex, float ActiveTime)
	{
	}

	public void CenterPopUp(string Message, int AudioClipIndex)
	{
	}

	public void CenterPopUp(string Message, int AudioClipIndex, float ActiveTime)
	{
	}

	public void GlobalPopUp(string Message, int AudioClipIndex, float ActiveTime)
	{
	}

	public void ToggleTutorial(bool TutorialActive, string Message)
	{
	}

	public void ToggleVideoTutorial(bool VideoActive, string Message, VideoClip Clip)
	{
	}

	public void ToggleInformation(bool InformationActive, string InformationTitle, string InformationDescription, VideoClip InformationClip)
	{
	}

	public void DisplaySubtitles(string SubtitleContent, float TimeToFade)
	{
	}

	public void SetHealthTypeGroup(int Index)
	{
	}

	public void Hit(int Index, Transform EnemyPosition, Color BarColor, Color BackgroundColor, float HealthPercentage, float DamagePercentage, float AdjustedDamage, string EnemyName)
	{
	}

	public void HideHealth()
	{
	}

	public void Fade(float Amount, Color FadeColor)
	{
	}

	public void DefineInventoryItem(string Name, string Description)
	{
	}

	public void PlaySoundEffect(AudioClip SoundEffect)
	{
	}

	public void ToggleScope(bool ToggleSetting)
	{
	}

	public void HideInformation()
	{
	}
}
