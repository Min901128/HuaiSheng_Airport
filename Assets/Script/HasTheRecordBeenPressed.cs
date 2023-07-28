using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasTheRecordBeenPressed : MonoBehaviour
{
    string IsFinalFinsh = "IsFinalFinsh";
    
    public void HasBeenPressed(){
        PlayerPrefs.SetInt("IsFinalFinsh", 1);
        PlayerPrefs.Save();
    }
}
