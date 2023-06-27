using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note01 : MonoBehaviour
{
    public GameObject Button;

    private const string P1Key = "P1";
    private const string P2Key = "P2";
    private const string P3Key = "P3";
    private const string P4Key = "P4";
    private const string C1Key = "C1";

    public void Record(){
        if(Button.tag == "6_1"){
            PlayerPrefs.SetInt(P1Key, 1);
        }
        else if(Button.tag == "6_2"){
            PlayerPrefs.SetInt(P2Key, 1);
        }
        else if(Button.tag == "6_3"){
            PlayerPrefs.SetInt(P3Key, 1);
        }
        else{
            PlayerPrefs.SetInt(P4Key, 1);
        }
        PlayerPrefs.Save();

        /*int score = PlayerPrefs.GetInt(P1Key); 
        Debug.Log("P1的值為" + score);*/
    }
}
