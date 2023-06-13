using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BordingSchedule : MonoBehaviour
{
    public GameObject Button;
    public Text Country;
    public Text CorrectAnswer;
    public GameObject MyAnswer;
    public GameObject Panel_Next;
    public GameObject Correct;
    public GameObject Error;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnButtonClick(){
        Country.text = Button.tag;
    }

    public void SetCorrectAnswer(){
        if(Button.tag == "Singapore"){
            CorrectAnswer.text = "1";
        }
        else if(Button.tag == "Tokyo"){
            CorrectAnswer.text = "2";
        }
        else{
            CorrectAnswer.text = "3";
        }
    }

    public void CheckAnswer(){
        Panel_Next.SetActive(true);Debug.Log(CorrectAnswer.text);
        if(MyAnswer.tag == CorrectAnswer.text){
            Correct.SetActive(true);
            
        }
        else{
            Error.SetActive(true);
        }
    }
}
