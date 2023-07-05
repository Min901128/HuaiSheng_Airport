using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat_Event_Mission3 : MonoBehaviour
{
    public Image DialogueImage;
	public GameObject Button;
	public Button ButtonDialogue;
	public GameObject ButtonYes;
	public GameObject ButtonNo;
	public GameObject NextPanel;

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
		if(chat_index == length-1){ //最後一個對話
			Button.SetActive(false);
			NextPanel.SetActive(true);
		}
		else if(chat_index == 3){
			ButtonDialogue.interactable = false;
			ButtonYes.SetActive(true);
			ButtonNo.SetActive(true);
		}
		else{
			chat_index++;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
	}

    public void AddIndex(){
        chat_index++;
        DialogueImage.sprite = DialogueSprite[chat_index];
    }
}
