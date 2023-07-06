using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject Singapore;
    public GameObject Tokyo;
    public GameObject Seoul;
    
    private const string MessageKey = "Country";
    
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
            Seoul.SetActive(true);
        }
    }
}