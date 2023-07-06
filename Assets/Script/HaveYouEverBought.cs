using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HaveYouEverBought : MonoBehaviour
{
    public GameObject S1;  //Singapore1
    public GameObject T1;  //Tokyo1
    public GameObject K1;  //Korea Seoul1;
    public GameObject Price1;
    public GameObject S2;
    public GameObject T2;
    public GameObject K2;
    public GameObject Price2;
    public GameObject S3;
    public GameObject T3;
    public GameObject K3;
    public GameObject Price3;

    private const string DutyFree1Key = "DutyFree1";
    private const string DutyFree2Key = "DutyFree2";
    private const string DutyFree3Key = "DutyFree3";

    void Start(){
        // PlayerPrefs.SetInt(DutyFree1Key, 0);
        // PlayerPrefs.SetInt(DutyFree2Key, 0);
        // PlayerPrefs.SetInt(DutyFree3Key, 0);
        bool situation1 = Convert.ToBoolean(PlayerPrefs.GetInt("DutyFree1"));
        bool situation2 = Convert.ToBoolean(PlayerPrefs.GetInt("DutyFree2"));
        bool situation3 = Convert.ToBoolean(PlayerPrefs.GetInt("DutyFree3"));
    
        S1.SetActive(!situation1);
        T1.SetActive(!situation1);
        K1.SetActive(!situation1);
        Price1.SetActive(!situation1);

        S2.SetActive(!situation2);
        T2.SetActive(!situation2);
        K2.SetActive(!situation2);
        Price2.SetActive(!situation2);

        S3.SetActive(!situation3);
        T3.SetActive(!situation3);
        K3.SetActive(!situation3);
        Price3.SetActive(!situation3);
    }

    public void Record1(){
        PlayerPrefs.SetInt("DutyFree1", 1);
        PlayerPrefs.Save();
    }

    public void Record2(){
        PlayerPrefs.SetInt("DutyFree2", 1);
        PlayerPrefs.Save();
    }

    public void Record3(){
        PlayerPrefs.SetInt("DutyFree3", 1);
        PlayerPrefs.Save();
    }
}
