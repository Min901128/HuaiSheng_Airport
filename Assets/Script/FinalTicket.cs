using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTicket : MonoBehaviour
{
	public Sprite[] Tickets;
	// Singapore, Tokyo, Seoul
	public Image TicketImage;
	string MessageKey = "Country";
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
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
