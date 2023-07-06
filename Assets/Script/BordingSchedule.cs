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
    public GameObject Panel_CorrectAndNext;
    public GameObject Panel_Error;

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
        if(MyAnswer.tag == CorrectAnswer.text){
            Panel_CorrectAndNext.SetActive(true);
        }
        else{
            Panel_Error.SetActive(true);
        }
    }
}