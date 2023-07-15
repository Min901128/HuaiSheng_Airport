using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Chat_Event_Mission8 : MonoBehaviour
{
    public Image DialogueImage;
	public GameObject Button;
    public Sprite[] DialogueSprite;
	public GameObject ButtonBackToMenu;
	

    int chat_index = 0;
	int length;

    void Start()
    {
		bool situation = Convert.ToBoolean(PlayerPrefs.GetInt("DutyFreeDialogue"));
		Button.SetActive(!situation);
		ButtonBackToMenu.SetActive(situation);

		PlayerPrefs.SetInt("DutyFreeDialogue", 0);
        PlayerPrefs.Save();

        chat_index = 0;
		length = DialogueSprite.Length;
		DialogueImage.sprite = DialogueSprite[0];
    }

    public void NextChat(){
		if(chat_index == length-1){
			Button.SetActive(false);
		}
		else{
			chat_index++;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
	}
}
