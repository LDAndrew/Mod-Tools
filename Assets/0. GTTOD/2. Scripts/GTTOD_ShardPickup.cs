using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_ShardPickup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpawnShards_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_ShardPickup _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CSpawnShards_003Ed__8(int _003C_003E1__state)
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

	public GTTOD_Shards ShardSpawn;

	public Vector2 ShardCountRange;

	public float ShardDistance;

	private bool Spawning;

	private int ShardCount;

	private Transform Player;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnShards_003Ed__8))]
	private IEnumerator SpawnShards()
	{
		return null;
	}
}
