using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat_Event_Mission2 : MonoBehaviour
{
    public Image DialogueImage;
	public GameObject Button;
    public Sprite[] DialogueSprite;

    int chat_index = 0;
	int length;

    void Start()
    {
        chat_index = 0;
		length = DialogueSprite.Length;
		DialogueImage.sprite = DialogueSprite[0];
    }

    public void NextChat(){
		if(chat_index == length-1){
			Button.SetActive(false);
		}
		else{
			if(chat_index == 1){
				Button.SetActive(false);
			}
			chat_index++;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
	}
}
