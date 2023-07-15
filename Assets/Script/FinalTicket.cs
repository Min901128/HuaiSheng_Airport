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
	string MoneyKey="MoneyKey", PackageScoreKey="PackageScoreKey", UFOKey="UFOKey", Puzzle1Key="Puzzle1Key", Puzzle2Key="Puzzle2Key";
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
		PuzzleText.text = "Level1 : " + PlayerPrefs.GetInt(Puzzle1Key).ToString() + " s\nLevel2 : " + PlayerPrefs.GetInt(Puzzle2Key).ToString() + " s";
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
