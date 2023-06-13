using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BordingSchedule : MonoBehaviour
{
    public GameObject Button;
    public Text Country;
    public Text CorrectAnswer;

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
        
    }
}
