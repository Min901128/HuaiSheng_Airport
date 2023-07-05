using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
	int ItemCount=7;
	public GameObject[] BagGameObjects;
	public Sprite[] TokyoItems;
	public Sprite[] SeoulItems;
	public Sprite[] SingaporeItems;
	Sprite[] CurrentItems;
	string MessageKey = "Country";
	// Start is called before the first frame update
	void Start()
	{
		if(BagGameObjects.Length==0)return;
		for (int i = 0; i < ItemCount; i++)
		{
			if(PlayerPrefs.GetInt("ItemId"+i,0)==1)
			{
				BagGameObjects[i].SetActive(true);
			}
		}
		string CountryName=PlayerPrefs.GetString(MessageKey);
		if(CountryName=="Singapore"){
			CurrentItems=SingaporeItems;
		}
		if(CountryName=="Tokyo"){
			CurrentItems=TokyoItems;
		}
		if(CountryName=="Seoul"){
			CurrentItems=SeoulItems;
		}
		for(int i=0;i<3;i++)
		{
			BagGameObjects[i+3].GetComponent<Image>().sprite=CurrentItems[i];
		}
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void GetItem(int id){
		PlayerPrefs.SetInt("ItemId"+id,1);
		PlayerPrefs.Save();
	}
}
