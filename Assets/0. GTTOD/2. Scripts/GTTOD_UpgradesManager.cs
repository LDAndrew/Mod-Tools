using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GTTOD_UpgradesManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayedWheelOfFortune_003Ed__158 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_UpgradesManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayedWheelOfFortune_003Ed__158(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public GTTOD_UltimateAbility CurrentUltimate;

	public PostProcessVolume PostProcessor;

	public GameObject RewardsEffect;

	public bool ShowUpgradeObjects;

	[ConditionalField("ShowUpgradeObjects", null)]
	public ParticleSystem AspectUpgradeEffect;

	[ConditionalField("ShowUpgradeObjects", null)]
	public AudioSource AspectProgressAudio;

	[ConditionalField("ShowUpgradeObjects", null)]
	public Animator AspectAnimator;

	[Space(15f)]
	public bool ShowKarmaObjects;

	[ConditionalField("ShowKarmaObjects", null)]
	public GameObject JusticeObject;

	[ConditionalField("ShowKarmaObjects", null)]
	public Material JusticeMaterial;

	[ConditionalField("ShowKarmaObjects", null)]
	public GameObject WorldStepExplosion;

	[ConditionalField("ShowKarmaObjects", null)]
	public GTTOD_Explosion TheSunExplosion;

	[ConditionalField("ShowKarmaObjects", null)]
	public Transform BlessedContent;

	[ConditionalField("ShowKarmaObjects", null)]
	public Transform CursedContent;

	[ConditionalField("ShowKarmaObjects", null)]
	public GTTOD_KarmaInventoryIcon KarmaInventoryIcon;

	public List<LeylineOption> LeylineOptions;

	public List<UlimateAbility> Ultimates;

	public List<WorkbenchRecipe> Recipes;

	public List<Rune> AttunementRunes;

	public List<Karma> BlessedKarma;

	public List<Karma> CursedKarma;

	public List<RankRewawrd> Ranks;

	public List<Aspect> Aspects;

	[Space(15f)]
	public List<Potential> WorldlyPotential;

	public List<GTTOD_LeylineOfferingUI> Offerings;

	public List<CanvasGroup> StatusEffectIcons;

	public List<AISpawn> QueenOfWandsSummons;

	public float UltimateCharge;

	[HideInInspector]
	public bool Frenzied;

	[HideInInspector]
	public bool AllCursesActive;

	[HideInInspector]
	public bool StatusActive;

	[HideInInspector]
	public bool WeaknessActive;

	[HideInInspector]
	public bool AspectsActive;

	[HideInInspector]
	public bool RewardsActive;

	[HideInInspector]
	public bool ColdEnvrionment;

	[HideInInspector]
	public bool ImmuneToStatic;

	[HideInInspector]
	public bool StrengthActive;

	[HideInInspector]
	public bool WorldStep;

	[HideInInspector]
	public bool TemporalShift;

	[HideInInspector]
	public bool SoulCharge;

	public bool WorldSpeed;

	[HideInInspector]
	public float ProgressionFill;

	[HideInInspector]
	public float DiademModifier;

	[HideInInspector]
	public int VinesSpent;

	[HideInInspector]
	public int MaxVines;

	public int AspectRank;

	[HideInInspector]
	public int CurrentUltimateID;

	[HideInInspector]
	public List<int> PotentialRewards;

	[HideInInspector]
	public List<int> PotentialBlessings;

	[HideInInspector]
	public List<int> PotentialCurses;

	[HideInInspector]
	public List<int> PotentialUltimates;

	[HideInInspector]
	public List<GTTOD_AspectUI> CurrentAspectUI;

	private ColorGrading ColorGradeEffect;

	private Bloom BloomEffect;

	private GameManager GM;

	private ac_OptionsMenu Pause;

	private GTTOD_HUD HUDManager;

	private GTTOD_Inventory Wheel;

	private GTTOD_Manager Manager;

	private GTTOD_AIManager AIManager;

	private GTTOD_HealthScript Health;

	private InventoryScript Inventory;

	private ac_CharacterController CharacterController;

	private GTTOD_HellfireController TheDevilHellfireSkulls;

	private Transform Player;

	private bool JusticeActive;

	private bool QueenOfWandsActive;

	private bool KingOfCupsActive;

	private bool PageOfPentaclesActive;

	private bool BeyondTriggered;

	private bool UnknownTriggered;

	private bool BurnActive;

	private bool StaticActive;

	private bool FrostActive;

	private bool HasReleased;

	private bool AspectProtection;

	private bool Overfilling;

	private bool Upgrading;

	private bool MaxedOut;

	private float UltimateDrainModifier;

	private float UltimateRegenModifier;

	private float DoublePointsTimer;

	private float InstaKillTimer;

	private float RapidFireTimer;

	private float SpeedBoostTimer;

	private float BurnTimer;

	private float BurnDamageTimer;

	private float StaticTimer;

	private float WeaknessTimer;

	private float FrenzyTimer;

	private float NormalSpeed;

	private float QOWTimer;

	private float AspectCurrentArea;

	private float SmoothAspectCurrentArea;

	private float Temperature;

	private float JusticeFogDistance;

	private float JusticeFogMinimum;

	private float KingOfCupsHeat;

	private float PageOfPentaclesTimer;

	private float TemperatureModifier;

	private int StrengthKills;

	private int OfferingCount;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void StatusUpdate()
	{
	}

	public void ToggleDoublePoints(bool Activate)
	{
	}

	public void ToggleQuadDamage(bool Activate)
	{
	}

	public void ToggleRapidFire(bool Activate)
	{
	}

	public void ToggleSpeedBoost(bool Activate)
	{
	}

	public void ToggleBurn(bool Activate)
	{
	}

	public void ToggleFrost(bool Activate)
	{
	}

	public void ToggleStatic(bool Activate)
	{
	}

	public void ToggleFrenzy(bool Activate)
	{
	}

	public void ToggleWeakness(bool Activate)
	{
	}

	public void ChargeKingOfCups()
	{
	}

	public void ChargeStrength(bool Charge)
	{
	}

	public void AddTemperature(float Amount)
	{
	}

	public void ClearAllDebuffs()
	{
	}

	public void OverchargePowerUp()
	{
	}

	public void AmmoBagPowerUp()
	{
	}

	public void MoneyBagPowerUp()
	{
	}

	public void ObliteratePowerUp()
	{
	}

	public void AmmoCratePowerUp()
	{
	}

	public void ExtraLifePowerUp()
	{
	}

	public void AcquireUltimate(int ID)
	{
	}

	public void ChargeUltimate()
	{
	}

	public void BumpReflex()
	{
	}

	public void UpgradeCurse(int CurseIndex)
	{
	}

	public void UpdateCurseUI(int CurseIndex)
	{
	}

	public float CurseLevel(string SearchedName)
	{
		return 0f;
	}

	public float CurseModifier(string SearchedName)
	{
		return 0f;
	}

	public GameObject CurseObject(string SearchedName)
	{
		return null;
	}

	public bool CurseMaxed(string SearchedName)
	{
		return false;
	}

	public void UpgradeBlessing(int BlessedIndex)
	{
	}

	public void UpdateBlessingUI(int BlessingIndex)
	{
	}

	public float BlessingLevel(string SearchedName)
	{
		return 0f;
	}

	public float BlessingModifier(string SearchedName)
	{
		return 0f;
	}

	public GameObject BlessingObject(string SearchedName)
	{
		return null;
	}

	public bool BlessingMaxed(string SearchedName)
	{
		return false;
	}

	public void CleanseAllKarma()
	{
	}

	public void DisableKarma(int ID, bool Blessing)
	{
	}

	public void DisableAllKarma()
	{
	}

	public void AdjustAllKarma()
	{
	}

	public void AdjustKarma(string KarmaName, int KarmaLevel)
	{
	}

	public void ToggleAspects(bool AspectActive)
	{
	}

	public void UpgradeAspect(int AspectIndex, int PotentialIndex)
	{
	}

	public void AdjustAspects(bool Save)
	{
	}

	public int GetAspectLevel(string AspectName)
	{
		return 0;
	}

	private void KeyAdjustment(bool Right)
	{
	}

	public void SetAspectContentPosition(float Area)
	{
	}

	public void SetAspectPlate(bool RightPlate, string PlateBaseText, string PlateSubText)
	{
	}

	public void SetAspectText(bool RightText, string Text)
	{
	}

	public void ToggleRewards(bool RewardActive)
	{
	}

	public void SetRewardDetails(string Name, string Description)
	{
	}

	public void AcceptReward(int RewardIndex, int BonusIndex)
	{
	}

	public void AdjustAttunements()
	{
	}

	public void SetAttunement(int AttunementIndex)
	{
	}

	public bool AttunementEnabled(string SearchedName)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CDelayedWheelOfFortune_003Ed__158))]
	private IEnumerator DelayedWheelOfFortune()
	{
		return null;
	}
}
