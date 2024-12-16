using System.Collections.Generic;
using UnityEngine;

public static class KeyBindingManager
{
	public static Dictionary<KeyAction, KeyCode> keyDict;

	public static Dictionary<string, KeyCode> buttonDict;

	public static KeyCode GetKeyCode(KeyAction key)
	{
		return default(KeyCode);
	}

	public static bool GetKey(KeyAction key)
	{
		return false;
	}

	public static bool GetKeyDown(KeyAction key)
	{
		return false;
	}

	public static bool GetKeyUp(KeyAction key)
	{
		return false;
	}

	public static void UpdateDictionary(KeyBinding key)
	{
	}
}
