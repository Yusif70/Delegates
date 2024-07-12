using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.task3
{
	public class Class3
	{
		public delegate void Action();
		public static void ReadFile(string path)
		{
			string[] lines = File.ReadAllLines(path);
			foreach (string line in lines)
			{
                Console.WriteLine(line);
            }
		}
		public static void WriteFile(string path, string content)
		{
			File.AppendAllText(path, content);
		}
		public static void Encrypt(string sourcePath, string destPath)
		{
			string[] lines = File.ReadAllLines(sourcePath);
			Stream st = File.Open(destPath, FileMode.OpenOrCreate);
			BinaryFormatter bf = new();
			bf.Serialize(st, lines);
			st.Close();
		}
	}
}
