using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordWhereIWillGo : MonoBehaviour
{
    public GameObject CountryButton;

    private const string MessageKey = "Country";
    
    public void Record(){
        string CountryName = CountryButton.tag;
        PlayerPrefs.SetString(MessageKey, CountryName);
        PlayerPrefs.Save();  

        Debug.Log("你選擇的國家為" + CountryName + "，已記錄");  
    }
}
