using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DutyFreesManager : MonoBehaviour
{
    public GameObject Singapore;
    public GameObject Tokyo;
    public GameObject Korea;
    
    private const string MessageKey = "Country";

    public Image Panel;
    public Sprite[] DutyFreeSprite;


    //int DutyFreeNum;
    
    public void Start(){
        string message = PlayerPrefs.GetString(MessageKey);
        
        Debug.Log("Country為" + message + "，已顯示");

        if(message == "Singapore"){
            Singapore.SetActive(true);
        }
        else if(message == "Tokyo"){
            Tokyo.SetActive(true);
        }
        else{
            Korea.SetActive(true);
        }
    }

    public void SetDutyFreeNum(GameObject button){ //這個函式掛在每個按鈕上，判斷屬於哪種DutyFree
        if(button.tag == "50"){
            //Sprite設為第一張
            Panel.sprite = DutyFreeSprite[0];
        }
        else if(button.tag == "100"){
            //Sprite設為第二張
            Panel.sprite = DutyFreeSprite[1];
        }
        else{
            //Sprite設為第三張
            Panel.sprite = DutyFreeSprite[2];
        }
    }
}
