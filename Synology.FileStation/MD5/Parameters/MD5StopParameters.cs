﻿using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
namespace Synology.FileStation.MD5.Parameters
{
	public class MD5StopParameters : RequestParameters
	{
		[Required]
		public string TaskID { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("taskid", TaskID)
			};
		}
	}
}

