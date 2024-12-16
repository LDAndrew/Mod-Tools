using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Structure : MonoBehaviour
{
	public enum RotationType
	{
		Player,
		Connected,
		Centered
	}

	[CompilerGenerated]
	private sealed class _003CDestroyGridSegments_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Structure _003C_003E4__this;

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
		public _003CDestroyGridSegments_003Ed__11(int _003C_003E1__state)
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

	public RotationType StructureRotationType;

	public LayerMask GridLayer;

	public LayerMask AditionalGridLayer;

	public List<Transform> CastPoints;

	public List<Transform> AdditionalGrids;

	private RS_Level LevelManagement;

	private bool Active;

	private void Start()
	{
	}

	public bool PlacementSecured()
	{
		return false;
	}

	public void ActivateStructure()
	{
	}

	[IteratorStateMachine(typeof(_003CDestroyGridSegments_003Ed__11))]
	private IEnumerator DestroyGridSegments()
	{
		return null;
	}
}
