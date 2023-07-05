using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Chat_Event_Mission6_Final : MonoBehaviour
{
    public Image DialogueImage;
	public GameObject Button;
	public Button ButtonDialogue;

	public Image person2Image;
    public GameObject Button2;
    public Button ButtonDialogue2;

	public Image person3Image;
    public GameObject Button3;
	public Button ButtonDialogue3;

    public Image person4Image;
	public GameObject Button4;
	public Button ButtonDialogue4;
	
    public Sprite[] DialogueSprite;
    public Sprite[] person2;
	public Sprite[] person3;
	public Sprite[] person4;

    int chat_index = 0;
	int length;

    void Start()
    {
        chat_index = 0;
		length = DialogueSprite.Length;
		DialogueImage.sprite = DialogueSprite[0];
        person2Image.sprite = person2[0];
		person3Image.sprite = person3[0];
		person4Image.sprite = person4[0];
    }

    public void NextChat_Final1(){
		if(chat_index == length-1){
			Button.SetActive(false);
			chat_index = 0;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
		else{
			chat_index++;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
	}

    public void NextChat_Final2(){
		if(chat_index == length-1){
			Button2.SetActive(false);
			chat_index = 0;
			person2Image.sprite = person2[chat_index];
		}
		else{
			chat_index++;
			person2Image.sprite = person2[chat_index];
		}
	}

    public void NextChat_Final3(){
		if(chat_index == length-1){
			Button3.SetActive(false);
			chat_index = 0;
			person3Image.sprite = person3[chat_index];
		}
		else{
			chat_index++;
			person3Image.sprite = person3[chat_index];
		}
	}

    public void NextChat_Final4(){
		if(chat_index == length-1){
			Button4.SetActive(false);
			chat_index = 0;
			person4Image.sprite = person4[chat_index];
		}
		else{
			chat_index++;
			person4Image.sprite = person4[chat_index];
		}
	}
}
