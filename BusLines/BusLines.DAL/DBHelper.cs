﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenagjimiAutobusav.DAL
{
	public class DBHelper
	{

		public static string GetConnectionString()
		{

			var path = @"C:\Users\HP\Desktop\Semestri-IV\SadikuIdriziHyseni\BusLines\BusLines.DAL\AppSettings.json";

			try
			{
				var file = File.ReadAllText(path);
				var jObject = JObject.Parse(file);
				var connectionString = (string)jObject["ConnectionStrings"]["Fatbardha"];
				return connectionString;
			}
			catch (Exception ex)
			{
				throw new Exception("Error reading connection string from AppSettings.json: " + ex.Message);
			}
		}
	}
}
