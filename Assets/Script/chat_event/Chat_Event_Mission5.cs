using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat_Event_Mission5 : MonoBehaviour
{
    public Image DialogueImage;
	public GameObject Button;
	public Button ButtonDialogue;
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
		if(chat_index == length-1){
			Button.SetActive(false);
			NextPanel.SetActive(true);
			//item1.SetActive(true);
		}
		else{
			if(chat_index == 4){
				Button.SetActive(false);
			}
			chat_index++;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
	}
}
