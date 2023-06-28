using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat_event : MonoBehaviour
{
	public Image DialogueImage;
	public GameObject Button;
	public Button ButtonDialogue; //tmp6-1
	public GameObject ButtonYes; //tmp6-1
	public GameObject ButtonNo; //tmp6-1
	public GameObject NextPanel; //tmp6-1
	public GameObject item1; //tmp4
	public GameObject item2; //tmp4
	public GameObject item3; //tmp4
	public GameObject item4; //tmp4
	public GameObject item5; //tmp4
	public GameObject item6; //tmp4
	public Sprite[] DialogueSprite;
	public Sprite[] person2; //tmp6_final
	public Sprite[] person3; //tmp6_final
	public Sprite[] person4; //tmp6_final
	public Image person2Image;
	public Image person3Image;
	public Image person4Image;
	public Button ButtonDialogue2;
	public Button ButtonDialogue3;
	public Button ButtonDialogue4;
	public GameObject Button2;
	public GameObject Button3;
	public GameObject Button4;
	
	int chat_index = 0;
	int length;
	
	void Start(){
		length = DialogueSprite.Length;
		DialogueImage.sprite = DialogueSprite[0];
		person2Image.sprite = person2[0];
		person3Image.sprite = person3[0];
		person4Image.sprite = person4[0];
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
	
	public void NextChat_BordingSchedule(){
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

	public void NextChat_Temp_6_1(){
		if(chat_index == length-1){
			//按鈕交互關掉、要不要按鈕出現
			ButtonDialogue.interactable = false;
			Debug.Log("按鈕交互已關閉");
			ButtonYes.SetActive(true);
			ButtonNo.SetActive(true);
		}
		else{
			chat_index++;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
	}

	public void NextChat_Temp_6_2__6_3(){
		if(chat_index == length-1){
			NextPanel.SetActive(true);
		}
		else{
			chat_index++;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
	}

	public void NextChat_BeforeBording(){
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
	
	public void NextChat_TinyGame(){
		if(chat_index == length-1){
			Button.SetActive(false);
			NextPanel.SetActive(true);
			item1.SetActive(true);
		}
		else{
			if(chat_index == 4){
				Button.SetActive(false);
			}
			chat_index++;
			DialogueImage.sprite = DialogueSprite[chat_index];
		}
	}

	public void NextChat_Tmp4(){
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

	public void Final_1(){
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

	public void Final_2(){
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

	public void Final_3(){
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

	public void Final_4(){
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
	/*public string[] person;
	public string[] context;
	public Sprite[] frame;	
	public Text person_obj;
	public Text context_obj;
	public Image ImageFrame;
	int chat_index=0;
	int length;
    // Start is called before the first frame update
    void Start()
    {
        length=context.Length;
		person_obj.text=person[0];
		context_obj.text=context[0];

		ImageFrame.sprite = frame[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void nextChat()
	{
		person_obj.text=person[chat_index];
		context_obj.text=context[chat_index];
		ImageFrame.sprite = frame[chat_index]; 
		chat_index++;
	}*/
}
