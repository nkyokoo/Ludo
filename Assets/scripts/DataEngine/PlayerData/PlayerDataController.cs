using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerDataController : MonoBehaviour
{
	public void playerData()
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ludo\data\player.json";
		List<data> _data = new List<data>();
		_data.Add(new data()
		{
			Id = 1,
			SSN = 2,
			Message = "A Message"
		});

		string json = JsonConvert.SerializeObject(_data.ToArray());

		try
		{

			if (File.Exists(path))
			{
				File.Delete(path);
			}
			using (FileStream fs = File.Create(path))
			{
				
				fs.Write(info, 0, info.Length);
			}

			using (StreamReader sr = File.OpenText(path))
			{
				string s = "";
				while ((s = sr.ReadLine()) != null)
				{
					Debug.Log(s);
				}
			}
		}

		catch (Exception ex)
		{
			Debug.Log(ex.ToString());
		}
	}
}

