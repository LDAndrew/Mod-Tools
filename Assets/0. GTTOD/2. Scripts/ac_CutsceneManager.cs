using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ac_CutsceneManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartCutscene_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ac_CutsceneManager _003C_003E4__this;

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
		public _003CStartCutscene_003Ed__14(int _003C_003E1__state)
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

	public bool PlayOnStart;

	[ConditionalField("PlayOnStart", null)]
	public float StartCutsceneDelay;

	[ConditionalField("PlayOnStart", null)]
	public int StartCutsceneID;

	[ConditionalField("PlayOnStart", null)]
	public Vector3 StartCutscenePosition;

	[ConditionalField("PlayOnStart", null)]
	public Vector3 StartCutsceneRotation;

	public List<ac_Cutscene> Cutscenes;

	[HideInInspector]
	public ac_Cutscene CurrentScene;

	[HideInInspector]
	public bool PlayingScene;

	private ac_CharacterController CharacterController;

	private InventoryScript Inventory;

	private Rigidbody PlayerPhysics;

	private GTTOD_Inventory Wheel;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CStartCutscene_003Ed__14))]
	private IEnumerator StartCutscene()
	{
		return null;
	}

	public void PlayCutscene(int SceneID, Vector3 ScenePosition, Quaternion SceneRotation)
	{
	}

	public void EndCutscene(Vector3 ScenePosition, float SceneRotation, Vector2 SceneForce)
	{
	}
}
