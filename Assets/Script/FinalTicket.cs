using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTicket : MonoBehaviour
{
	public Sprite[] Tickets;
	// Singapore, Tokyo, Seoul
	public Image TicketImage;
	public Text MoneyText, PackageScoreText, UFOText, PuzzleText;
	string MessageKey = "Country";
	string MoneyKey="MoneyKey", PackageScoreKey="PackageScoreKey", UFOKey="UFOKey", PuzzleKey="PuzzleKey";
	// Start is called before the first frame update
	void Start()
	{
		string CountryName=PlayerPrefs.GetString(MessageKey);
		if(CountryName=="Singapore"){
			TicketImage.sprite=Tickets[0];
		}
		if(CountryName=="Tokyo"){
			TicketImage.sprite=Tickets[1];
		}
		if(CountryName=="Seoul"){
			TicketImage.sprite=Tickets[2];
		}
		MoneyText.text = PlayerPrefs.GetInt(MoneyKey).ToString();
		PackageScoreText.text = PlayerPrefs.GetInt(PackageScoreKey).ToString()+" / 6";
		UFOText.text = PlayerPrefs.GetInt(UFOKey).ToString();
		PuzzleText.text = PlayerPrefs.GetInt(PuzzleKey).ToString();
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
