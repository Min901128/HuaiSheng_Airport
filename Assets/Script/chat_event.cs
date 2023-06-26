using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat_event : MonoBehaviour
{
	public Image DialogueImage;
	public GameObject Button;
	public Sprite[] DialogueSprite;
	
	int chat_index = 0;
	int length;
	
	void Start(){
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
