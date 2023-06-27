using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
	int ItemCount=7;
	public GameObject[] BagGameObjects;
	// Start is called before the first frame update
	void Start()
	{
		if(BagGameObjects.Length==0)return;
		for (int i = 0; i < ItemCount; i++)
		{
			if(PlayerPrefs.GetInt("ItemId"+i,0)==1){
				BagGameObjects[i].SetActive(true);
			}
		}
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void GetItem(int id){
		PlayerPrefs.SetInt("ItemId"+id,1);
	}
}
