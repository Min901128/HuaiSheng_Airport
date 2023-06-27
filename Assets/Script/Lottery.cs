using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lottery : MonoBehaviour
{
	public Image[] Cards;
	public Text LotteryCountText, MoneyText, Hint_Text;
	public GameObject DisableAllPanel;
	public Sprite CardBackSprite;
	public Sprite[] CardValueSprite;
	string LotteryCountKey="LotteryCountKey", MoneyKey="MoneyKey";
	string PollState="";
	int[] LotteryValues = new int[]{50,40,30};
	int LotteryCount,Money;
	float ShowNotPolledCountDown,PutCardsBackCountDown;
	// Start is called before the first frame update
	void Start()
	{
		// PlayerPrefs.SetInt(LotteryCountKey,50);
		// PlayerPrefs.Save();
		LotteryCount=PlayerPrefs.GetInt(LotteryCountKey,0);
		Money=PlayerPrefs.GetInt(MoneyKey,0);
		LotteryCountText.text=LotteryCount.ToString();
		MoneyText.text=Money.ToString();
	}

	// Update is called once per frame
	void Update()
	{
		if(PollState=="REVEALING NOT POLLED CARD"){
			if(ShowNotPolledCountDown>=0) ShowNotPolledCountDown-=Time.deltaTime;
			if(ShowNotPolledCountDown<=0){
				Debug.Log("REVEALING NOT POLLED CARD");
				for (int i = 0; i < 3; i++)
				{
					Cards[i].sprite=CardValueSprite[CardValueToSpriteIndex(LotteryValues[i])];
				}
				PollState="PUT CARDS BACK";
				PutCardsBackCountDown=2.0f;
			}
		}
		if(PollState=="PUT CARDS BACK"){
			PutCardsBackCountDown-=Time.deltaTime;
			if(PutCardsBackCountDown<=0){
				Debug.Log("PUT CARDS BACK");
				for (int i = 0; i < 3; i++)
				{
					Cards[i].sprite=CardBackSprite;
				}
				PollState="";
				DisableAllPanel.SetActive(false);
			}
		}
	}

	public void Poll(int id){
		if(LotteryCount==0){
			Hint_Text.text="No lottery left";
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			int a=Random.Range(0,3),b=Random.Range(0,3);
			if(a==b)continue;
			int temp=LotteryValues[a];
			LotteryValues[a]=LotteryValues[b];
			LotteryValues[b]=temp;
		}
		Debug.Log(LotteryValues[id]);
		Cards[id].sprite=CardValueSprite[CardValueToSpriteIndex(LotteryValues[id])];

		LotteryCount--;
		Money+=LotteryValues[id];
		
		PlayerPrefs.SetInt(LotteryCountKey,	LotteryCount);
		PlayerPrefs.SetInt(MoneyKey, Money);
		PlayerPrefs.Save();
		LotteryCountText.text=LotteryCount.ToString();
		MoneyText.text=Money.ToString();

		ShowNotPolledCountDown=2.0f;
		PollState="REVEALING NOT POLLED CARD";
		DisableAllPanel.SetActive(true);
	}

	int CardValueToSpriteIndex(int value){
		return value/10-3;
	}
}
