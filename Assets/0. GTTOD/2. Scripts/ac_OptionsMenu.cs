using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ac_OptionsMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ac_OptionsMenu _003C_003E4__this;

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
		public _003CStart_003Ed__119(int _003C_003E1__state)
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

	[Header("MENU OBJECTS")]
	public bool ShowObjects;

	[ConditionalField("ShowObjects", null)]
	public CanvasGroup OptionsMenuGroup;

	[ConditionalField("ShowObjects", null)]
	public GameObject SelectionsWheel;

	[ConditionalField("ShowObjects", null)]
	public RectTransform Content;

	[ConditionalField("ShowObjects", null)]
	public GameObject MainCamera;

	[ConditionalField("ShowObjects", null)]
	public GameObject WeaponCamera;

	[ConditionalField("ShowObjects", null)]
	public GameObject UICamera;

	[ConditionalField("ShowObjects", null)]
	public PostProcessVolume WorldProcessor;

	[ConditionalField("ShowObjects", null)]
	public PostProcessVolume WeaponProcessor;

	[ConditionalField("ShowObjects", null)]
	public PostProcessVolume UIProcessor;

	[ConditionalField("ShowObjects", null)]
	public Text GameInfoText;

	[ConditionalField("ShowObjects", null)]
	public Text SeedText;

	[Header("AUDIO SETTINGS")]
	public bool ShowAudio;

	[ConditionalField("ShowAudio", null)]
	public Slider MasterVolumeSlider;

	[ConditionalField("ShowAudio", null)]
	public InputField MasterVolumeInput;

	[ConditionalField("ShowAudio", null)]
	public Slider MusicVolumeSlider;

	[ConditionalField("ShowAudio", null)]
	public InputField MusicVolumeInput;

	[ConditionalField("ShowAudio", null)]
	public Slider SFXVolumeSlider;

	[ConditionalField("ShowAudio", null)]
	public InputField SFXVolumeInput;

	[ConditionalField("ShowAudio", null)]
	public Slider VoiceVolumeSlider;

	[ConditionalField("ShowAudio", null)]
	public InputField VoiceVolumeInput;

	[ConditionalField("ShowAudio", null)]
	public Dropdown FilterDropdown;

	[ConditionalField("ShowAudio", null)]
	public Dropdown LanguageDropdown;

	[ConditionalField("ShowAudio", null)]
	public Toggle SubtitlesToggle;

	[Header("GAMEPLAY SETTINGS")]
	public bool ShowGameplay;

	[ConditionalField("ShowGameplay", null)]
	public Slider ScreenShakeSlider;

	[ConditionalField("ShowGameplay", null)]
	public InputField ScreenShakeInput;

	[ConditionalField("ShowGameplay", null)]
	public Slider AimAssistSlider;

	[ConditionalField("ShowGameplay", null)]
	public InputField AimAssistInput;

	[ConditionalField("ShowGameplay", null)]
	public Slider WallMagnetismSlider;

	[ConditionalField("ShowGameplay", null)]
	public InputField WallMagnetismInput;

	[ConditionalField("ShowGameplay", null)]
	public Toggle HoldJump;

	[ConditionalField("ShowGameplay", null)]
	public Toggle ForceDraw;

	[ConditionalField("ShowGameplay", null)]
	public Toggle CameraNudge;

	[ConditionalField("ShowGameplay", null)]
	public Toggle CozyMode;

	[ConditionalField("ShowGameplay", null)]
	public Text CozyModeText;

	[Header("BASIC CONTROLS")]
	public bool ShowBasicControls;

	[ConditionalField("ShowBasicControls", null)]
	public Slider SensitivitySlider;

	[ConditionalField("ShowBasicControls", null)]
	public InputField SensitivityInput;

	[ConditionalField("ShowBasicControls", null)]
	public Slider KeyHoldDurationSlider;

	[ConditionalField("ShowBasicControls", null)]
	public InputField KeyHoldDurationInput;

	[ConditionalField("ShowBasicControls", null)]
	public Toggle HoldReloadToDualWield;

	[ConditionalField("ShowBasicControls", null)]
	public Toggle HoldReloadToInspect;

	[ConditionalField("ShowBasicControls", null)]
	public Toggle MeleeIsInteract;

	[ConditionalField("ShowBasicControls", null)]
	public Toggle ToggleCrouch;

	[ConditionalField("ShowBasicControls", null)]
	public Toggle Invert;

	[Header("RESOLUTION")]
	public bool ShowResolution;

	[ConditionalField("ShowResolution", null)]
	public Dropdown ResolutionsDropdown;

	[ConditionalField("ShowResolution", null)]
	public Toggle Fullscreen;

	[ConditionalField("ShowResolution", null)]
	public Toggle Vsync;

	[ConditionalField("ShowResolution", null)]
	public Slider FieldOfViewSlider;

	[ConditionalField("ShowResolution", null)]
	public InputField FieldOfViewInput;

	[ConditionalField("ShowResolution", null)]
	public Slider FrameLimitSlider;

	[ConditionalField("ShowResolution", null)]
	public InputField FrameLimitInput;

	[Header("EFFECTS")]
	public bool ShowEffects;

	[ConditionalField("ShowEffects", null)]
	public Slider ColorRangeSlider;

	[ConditionalField("ShowEffects", null)]
	public InputField ColorRangeInput;

	[ConditionalField("ShowEffects", null)]
	public Slider BloomSlider;

	[ConditionalField("ShowEffects", null)]
	public InputField BloomInput;

	[ConditionalField("ShowEffects", null)]
	public Slider SaturationSlider;

	[ConditionalField("ShowEffects", null)]
	public InputField SaturationInput;

	[ConditionalField("ShowEffects", null)]
	public Slider ContrastSlider;

	[ConditionalField("ShowEffects", null)]
	public InputField ContrastInput;

	[ConditionalField("ShowEffects", null)]
	public Toggle AmbientOcclusion;

	[ConditionalField("ShowEffects", null)]
	public Toggle Outline;

	[ConditionalField("ShowEffects", null)]
	public Toggle Cavity;

	[ConditionalField("ShowEffects", null)]
	public Toggle Retro;

	[ConditionalField("ShowEffects", null)]
	public Toggle SunRays;

	[ConditionalField("ShowEffects", null)]
	public Toggle Shadows;

	[Header("HUD SETTINGS")]
	public bool ShowHUD;

	[ConditionalField("ShowHUD", null)]
	public Toggle HealthUI;

	[ConditionalField("ShowHUD", null)]
	public Toggle InventoryUI;

	[ConditionalField("ShowHUD", null)]
	public Toggle EnemyHealthBarUI;

	[ConditionalField("ShowHUD", null)]
	public Toggle DamageNumbersUI;

	[ConditionalField("ShowHUD", null)]
	public Toggle ReticleUI;

	[ConditionalField("ShowHUD", null)]
	public Toggle StatusEffectsUI;

	[Header("APPLICATION SETTINGS")]
	public bool ShowApplication;

	[ConditionalField("ShowApplication", null)]
	public InputField CustomModsPath;

	[ConditionalField("ShowApplication", null)]
	public Toggle ModsToggle;

	[ConditionalField("ShowApplication", null)]
	public Toggle ReplaceShadersToggle;

	[Header("STATISTICS SETTINGS")]
	public bool ShowStatistics;

	[Header("MENU LISTS")]
	public List<GameObject> OptionScreens;

	public List<KeyBinding> KeyBinds;

	[HideInInspector]
	public List<string> FreezeList;

	[HideInInspector]
	public bool InMenu;

	[HideInInspector]
	public bool Active;

	[HideInInspector]
	public float BaseMusicVolume;

	private GameManager GM;

	private ac_CharacterController CharacterController;

	private GTTOD_InteractionManager Interaction;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_ModManager ModManager;

	private GTTOD_HealthScript Health;

	private GTTOD_Manager Manager;

	private GTTOD_AIManager AIManager;

	private InventoryScript Inventory;

	private ac_DevConsole DevConsole;

	private GTTOD_OSTManager OST;

	private GTTOD_Story Story;

	private AmbientOcclusion WorldAO;

	private AmbientOcclusion WeaponAO;

	private ColorGrading UIColorGrading;

	private Bloom WorldBloom;

	private Resolution[] Resolutions;

	private List<Resolution> FilteredResolutions;

	private bool PauseProtection;

	private bool InFolder;

	private bool CanPause;

	private bool ShouldCycleMusic;

	private bool BlockResolutionChange;

	private float ScrollValue;

	private float MaxScrollValue;

	private int CurrentResolutionIndex;

	public bool EnablePause { get; set; }

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__119))]
	private IEnumerator Start()
	{
		return null;
	}

	public void DetectResolutions()
	{
	}

	private void Update()
	{
	}

	public void SetMasterVolume(float Volume)
	{
	}

	public void SetMasterVolume(string Volume)
	{
	}

	public void SetMusicVolume(float Volume)
	{
	}

	public void SetMusicVolume(string Volume)
	{
	}

	public void SetSFXVolume(float Volume)
	{
	}

	public void SetSFXVolume(string Volume)
	{
	}

	public void SetVoiceVolume(float Volume)
	{
	}

	public void SetVoiceVolume(string Volume)
	{
	}

	public void SetFilter(int Index)
	{
	}

	public void SetLanguage(int Index)
	{
	}

	public void SetSubtitles(bool Enabled)
	{
	}

	public void SetScreenShake(float ScreenShake)
	{
	}

	public void SetScreenShake(string SS)
	{
	}

	public void SetAimAssist(float AimAssist)
	{
	}

	public void SetAimAssist(string AA)
	{
	}

	public void SetWallMagnetism(float Magnetism)
	{
	}

	public void SetWallMagnetism(string WallMagnetism)
	{
	}

	public void SetHoldJump(bool Enabled)
	{
	}

	public void SetForceDraw(bool Enabled)
	{
	}

	public void SetCameraNudge(bool Enabled)
	{
	}

	public void SetCozyMode(bool Enabled)
	{
	}

	public void CycleMusic()
	{
	}

	public void SetSensitivty(float Sensitivity)
	{
	}

	public void SetSensitivty(string Sens)
	{
	}

	public void SetKeyHoldDuration(float Duration)
	{
	}

	public void SetKeyHoldDuration(string Duration)
	{
	}

	public void SetHoldReloadToDualWield(bool Enabled)
	{
	}

	public void SetHoldReloadToInspect(bool Enabled)
	{
	}

	public void SetMeleeIsInteract(bool Enabled)
	{
	}

	public void SetToggleCrouch(bool Enabled)
	{
	}

	public void SetInvert(bool Enabled)
	{
	}

	public void SetResolution(int Index)
	{
	}

	public void SetFullscreen(bool IsFullscreen)
	{
	}

	public void SetFieldOfView(float FOV)
	{
	}

	public void SetFieldOfView(string FOV)
	{
	}

	public void SetFrameLimit(float Limit)
	{
	}

	public void SetFrameLimit(string Limit)
	{
	}

	public void SetVsync(bool Enabled)
	{
	}

	public void SetColorRange(float Range)
	{
	}

	public void SetColorRange(string Range)
	{
	}

	public void SetBloom(float Bloom)
	{
	}

	public void SetBloom(string Bloom)
	{
	}

	public void SetSaturation(float Saturation)
	{
	}

	public void SetSaturation(string Saturation)
	{
	}

	public void SetContrast(float Contrast)
	{
	}

	public void SetContrast(string Contrast)
	{
	}

	public void SetAmbientOcclusion(bool Enabled)
	{
	}

	public void SetOutline(bool Enabled)
	{
	}

	public void SetCavity(bool Enabled)
	{
	}

	public void SetRetro(bool Enabled)
	{
	}

	public void SetSunRays(bool Enabled)
	{
	}

	public void SetShadows(bool Enabled)
	{
	}

	public void SetHealthUI(bool Enabled)
	{
	}

	public void SetInventoryUI(bool Enabled)
	{
	}

	public void SetEnemyHealthBarsUI(bool Enabled)
	{
	}

	public void SetDamageNumbersUI(bool Enabled)
	{
	}

	public void SetReticleUI(bool Enabled)
	{
	}

	public void SetStatusEffectsUI(bool Enabled)
	{
	}

	public void SetCustomModPath(string ModPath)
	{
	}

	public void SetMods(bool Enabled)
	{
	}

	public void SetReplaceShaders(bool Enabled)
	{
	}

	public void AdjustSettings(bool Pull)
	{
	}

	public void AdjustFreezeList(string FreezeSource, bool Add)
	{
	}

	public void SetMaxScroll(float NewMax)
	{
	}

	public void Scroll(float Value)
	{
	}

	public void ResetScroll()
	{
	}

	public void TogglePause(bool Pause)
	{
	}

	public void TogglePause(bool Pause, int StartScreen)
	{
	}

	public void SetGameInfoText()
	{
	}

	public void OpenFolder(int Screen)
	{
	}

	public void Back()
	{
	}

	public void ExitGame()
	{
	}

	public void FillKeybinds()
	{
	}
}
