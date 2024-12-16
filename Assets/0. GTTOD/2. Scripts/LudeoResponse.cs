using System;
using System.Collections.Generic;

public class LudeoResponse
{
	public readonly Guid Guid;

	public IReadOnlyDictionary<string, object> State;

	internal LudeoResponse(string guid, IReadOnlyDictionary<string, object> ludeoState)
	{
	}
}
