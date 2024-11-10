using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class FinalTicket : MonoBehaviour
{
	public Sprite[] Tickets;
	// Singapore, Tokyo, Seoul
	public Image TicketImage, SelfieImage;
	public Text MoneyText, PackageScoreText, UFOText, PuzzleText, NameText;
	string MessageKey = "Country";
	string MoneyKey="MoneyKey", PackageScoreKey="PackageScoreKey", UFOKey="UFOKey", Puzzle1Key="Puzzle1Key", Puzzle2Key="Puzzle2Key";
	string PassportNameKey = "PassportNameKey";
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

		NameText.text = PlayerPrefs.GetString(PassportNameKey);

		try
		{
			string filename = Path.Combine(Application.persistentDataPath, "selfie.png");
			var rawData = System.IO.File.ReadAllBytes(filename);
			Texture2D tex = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter (she said)
			tex.LoadImage(rawData);
			int rect_width, rect_height;
			if (tex.width >= tex.height)
			{
				rect_width = tex.height;
				rect_height = tex.height;
			}
			else
			{
				rect_width = tex.width;
				rect_height = tex.width;
			}
			SelfieImage.sprite = Sprite.Create(tex, new Rect(0, 0, rect_width, rect_height), Vector2.zero);
		}
		catch (System.Exception)
		{
			SelfieImage.gameObject.SetActive(false);
			throw;
		}

	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
