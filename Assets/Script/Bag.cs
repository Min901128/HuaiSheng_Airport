using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; 

public class Bag : MonoBehaviour
{
	int ItemCount=7;
	public GameObject[] BagGameObjects;
	public Sprite[] TokyoItems;
	public Sprite[] SeoulItems;
	public Sprite[] SingaporeItems;
	public GameObject BagLock;
	Sprite[] CurrentItems;
	string MessageKey = "Country", MoneyKey="MoneyKey";
	string somekey="finished_state";
	int money;

	// Start is called before the first frame update
	void Start()
	{
		int finished_state=PlayerPrefs.GetInt(somekey,0);
		if(finished_state>=30 && BagLock!=null) BagLock.SetActive(false);
		money=PlayerPrefs.GetInt(MoneyKey,0);
		if(BagGameObjects.Length==0)return;
		for (int i = 0; i < ItemCount; i++)
		{
			if(PlayerPrefs.GetInt("ItemId"+i,0)==1)
			{
				if(BagGameObjects[i]!=null)
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
			if(CurrentItems==null) break;
			BagGameObjects[i+4].GetComponent<Image>().sprite=CurrentItems[i];
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

	public void IncreaseMoney(int mount){
		money+=mount;
		PlayerPrefs.SetInt(MoneyKey,money);
		PlayerPrefs.Save();
	}

	public void DecreaseMoney(int mount){
		money-=mount;
		PlayerPrefs.SetInt(MoneyKey,money);
		PlayerPrefs.Save();
	}
}