using System;
using UnityEngine;

[Serializable]
public class WorkbenchRecipe
{
	public string RecipeName;

	public bool RecipeAccessible;

	[Header("INGREDIENTS")]
	public string LethalName;

	public string TacticalName;
}
