using System;
using System.Collections.Generic;

public class EventMediator
{
	private abstract class EventHelper
	{
	}

	private class EventHelper<T> : EventHelper
	{
		private Dictionary<string, Action<T>> _subscribers;

		public void Publish(string eventAction, T args)
		{
		}

		public void Subscribe(string eventAction, Action<T> action)
		{
		}

		public void Unsubscribe(string eventAction, Action<T> action)
		{
		}
	}

	private static EventMediator _instance;

	private Dictionary<Type, EventHelper> _eventHelpers;

	public static EventMediator Instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private EventMediator()
	{
	}

	public void Publish<T>(string eventAction, T args)
	{
	}

	public void Subscribe<T>(string eventAction, Action<T> action)
	{
	}

	public void Unsubscribe<T>(string eventAction, Action<T> action)
	{
	}
}
