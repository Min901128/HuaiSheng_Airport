using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ClearRecord : MonoBehaviour
{
	public void Clear(){
		PlayerPrefs.DeleteAll();
		DeleteFile("selfie.png");
	}

	public void DeleteFile(string fileName)
	{
		// Construct the full path of the file
		string filePath = Path.Combine(Application.persistentDataPath, fileName);

		// Check if the file exists before attempting to delete
		if (File.Exists(filePath))
		{
			File.Delete(filePath);
			Debug.Log($"File {fileName} deleted successfully.");
		}
		else
		{
			Debug.LogWarning($"File {fileName} does not exist at {filePath}.");
		}
	}
}
