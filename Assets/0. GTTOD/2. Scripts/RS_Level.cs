using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RS_Level : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSwitchStageState_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RS_Level _003C_003E4__this;

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
		public _003CSwitchStageState_003Ed__26(int _003C_003E1__state)
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

	public string StageTime;

	public Transform GridParent;

	public Transform GridPosition;

	public Structure StructureToPlace;

	public List<StructureItem> Structures;

	[HideInInspector]
	public List<RS_EnemyObjective> Objectives;

	public List<Transform> GridPoints;

	[HideInInspector]
	public bool GameStarted;

	[HideInInspector]
	public bool PowerOn;

	private GameManager GM;

	private NavigationBuilder Navigation;

	private ac_CharacterController CharacterController;

	private GameObject Player;

	private Transform CurrentGridSelected;

	private StructureItem CurrentStructure;

	private StructureItem NextStructure;

	private float TimeToCheckPoint;

	private float TimeRemaining;

	private bool Active;

	private bool Building;

	private void Start()
	{
	}

	public void AssignObjectives()
	{
	}

	public void AssignGrid()
	{
	}

	private void CycleStructures()
	{
	}

	private void Update()
	{
	}

	private void DisplayTime(float timeToDisplay)
	{
	}

	[IteratorStateMachine(typeof(_003CSwitchStageState_003Ed__26))]
	private IEnumerator SwitchStageState()
	{
		return null;
	}

	private Vector3 FindNearestPoint(Vector3 LookPosition)
	{
		return default(Vector3);
	}

	private Quaternion SnapToCenterRotation(Vector3 RotationPoint)
	{
		return default(Quaternion);
	}
}
