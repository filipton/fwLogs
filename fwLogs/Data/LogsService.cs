using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fwLogs.Data
{
	public static class LogsService
	{
		public static Dictionary<string, List<string>> AllLogs = new Dictionary<string, List<string>>();

		public static void AddLog(string key, string content)
		{
			if (AllLogs.ContainsKey(key))
			{
				AllLogs[key].Insert(0, $"[{DateTime.Now.ToString()}] {content}");
			}
			else
			{
				AllLogs.Add(key, new List<string>() { $"[{DateTime.Now.ToString()}] {content}" });
			}
		}

		public static void ClearLog(string key)
		{
			if (AllLogs.ContainsKey(key))
			{
				AllLogs.Remove(key);
			}
		}

		public static void ClearLogs()
		{
			AllLogs.Clear();
		}
	}
}