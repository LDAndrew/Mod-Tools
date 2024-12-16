using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_WorldlyPotential : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpgradeEffectRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_WorldlyPotential _003C_003E4__this;

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
		public _003CUpgradeEffectRoutine_003Ed__27(int _003C_003E1__state)
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

	public VerticalLayoutGroup PotentialLayout;

	public CanvasGroup RegenerateVignette;

	public CanvasGroup PotentialGroup;

	public CanvasGroup EffectGroup;

	public ParticleSystem Effect;

	public Text DescriptionText;

	public Text JadeVineText;

	public AudioSource Audio;

	public AudioSource Fade;

	public List<GTTOD_WorldlyPotentialSelection> Selections;

	public List<GameObject> RevealObjects;

	public List<AudioClip> SFX;

	public List<int> Padding;

	private ac_OptionsMenu OptionsMenu;

	private GTTOD_UpgradesManager Upgrades;

	private Image EffectsVignette;

	private GTTOD_Manager Manager;

	private Animator Anim;

	private bool Active;

	private bool SoundProtection;

	private int RevealCount;

	private float RegenerateProgress;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void AttemptReveal(int Cost)
	{
	}

	public void CycleSelections()
	{
	}

	public void UpgradeSelection()
	{
	}

	[IteratorStateMachine(typeof(_003CUpgradeEffectRoutine_003Ed__27))]
	private IEnumerator UpgradeEffectRoutine()
	{
		return null;
	}

	public void BumpEffect(float BumpAmount, Color BumpColor)
	{
	}

	public void ActivateSelections()
	{
	}

	public void ToggleDescription(string Description)
	{
	}

	public void PlaySFX(int Index)
	{
	}
}
