using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat_Event_Mission4 : MonoBehaviour
{
    public Image DialogueImage;
	public GameObject Button;
	public Button ButtonDialogue;
	public GameObject NextPanel;
    public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	public GameObject item5;
	public GameObject item6;

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
		else if(chat_index == 5){
			ButtonDialogue.interactable = false;
			item1.SetActive(true);
			item2.SetActive(true);
			item3.SetActive(true);
		}
		else if(chat_index == 9){
			ButtonDialogue.interactable = false;
			item4.SetActive(true);
			item5.SetActive(true);
			item6.SetActive(true);
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
