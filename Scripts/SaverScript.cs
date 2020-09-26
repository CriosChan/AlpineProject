using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaverScript
{
    public static void SaveUser(string user, string pass)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath.ToString() + "/users.bin";
		FileStream stream = new FileStream(path, FileMode.Create);
		
		UsersData data = new UsersData(user, pass);
		
		formatter.Serialize(stream, data);
		stream.Close();
	}
	
	public static UsersData LoadUser()
	{
		string path = Application.persistentDataPath.ToString() + "/users.bin";
		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);
			
			UsersData data = formatter.Deserialize(stream) as UsersData;
			stream.Close();
			
			return data;
		} else {
			Debug.LogError("Save file not found in " + path);
			return null;
		}
	}
}
