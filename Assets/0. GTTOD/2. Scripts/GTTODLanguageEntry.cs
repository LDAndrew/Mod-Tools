using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GTTODLanguageEntry
{
	public string TextDescription;

	[TextArea(1, 10)]
	public List<string> Languages;
}
