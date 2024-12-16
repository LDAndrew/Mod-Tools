using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_InteractionManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUseCooldown_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_InteractionManager _003C_003E4__this;

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
		public _003CUseCooldown_003Ed__15(int _003C_003E1__state)
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

	public LayerMask InteractLayers;

	public float InteractDistance;

	public GTTOD_Interactable CurrentInteractObject;

	public List<Transform> Pickups;

	[HideInInspector]
	public bool MeleeIsInteract;

	private GameManager GM;

	private GTTOD_HUD HUDManagement;

	private Transform RaycastDirectionRoot;

	private bool CanInteract;

	private float PickupCheckTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void InteractionUpdate()
	{
	}

	public void AdjustPickupList(Transform PickupObject, bool Add)
	{
	}

	private Transform GetClosestPickup(List<Transform> Pickups)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUseCooldown_003Ed__15))]
	private IEnumerator UseCooldown()
	{
		return null;
	}
}
