﻿using Synology.Classes;

namespace Synology.Api
{
	public abstract class MainApiRequest : SynologyRequest
	{
		protected MainApiRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, cgiPath, $"API.{api}")
		{
		}
	}
}