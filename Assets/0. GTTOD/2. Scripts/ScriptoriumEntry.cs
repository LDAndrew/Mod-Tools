using System;
using UnityEngine;

[Serializable]
public class ScriptoriumEntry
{
	public string EntryTitle;

	[TextArea(1, 15)]
	public string EntryDescription;
}
