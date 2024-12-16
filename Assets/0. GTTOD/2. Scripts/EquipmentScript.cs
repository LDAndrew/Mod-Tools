using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EquipmentScript : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUse_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EquipmentScript _003C_003E4__this;

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
		public _003CUse_003Ed__27(int _003C_003E1__state)
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

	public bool Tactical;

	public bool Refill;

	public string EquipmentName;

	public Transform EquipmentPoint;

	public SkinnedMeshRenderer Arms;

	public Vector3 EquipmentPosition;

	public Vector3 EquipmentRotation;

	public Vector3 EquipmentIdlePosition;

	public float EquipmentRefillTime;

	public int EquipmentUses;

	public List<EquipmentUsage> EquipmentUsages;

	[HideInInspector]
	public int EquipmentID;

	private GameManager GM;

	private Animator Anim;

	private AudioSource Audio;

	private ac_CharacterController CharacterController;

	private InventoryScript Inventory;

	private GameObject PreviousItem;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUD;

	[HideInInspector]
	public float CurrentUses;

	private int Cycle;

	[HideInInspector]
	public bool UsingEquipment;

	private bool CanUse;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UseEquipment()
	{
	}

	[IteratorStateMachine(typeof(_003CUse_003Ed__27))]
	private IEnumerator Use()
	{
		return null;
	}

	public void EndEquipment()
	{
	}

	public void RestockEquipment()
	{
	}

	public void TriggerEquipment()
	{
	}

	public void RoughShake()
	{
	}

	public void OnDestroy()
	{
	}
}
