using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearRecord : MonoBehaviour
{
	public void Clear(){
		PlayerPrefs.DeleteAll();
	}
}
