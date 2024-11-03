using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Note : MonoBehaviour
{
    public Image Person1;
    public Image Person2;
    public Image Person3;
    public Image Person4;
    public Image Collected;
    public Sprite[] Person1Sprite; //Nara
    public Sprite[] Person2Sprite; //山本太郎
    public Sprite[] Person3Sprite; //德文洛根
    public Sprite[] Person4Sprite; //金漢軟
    public Sprite[] IsCollected; //是否完成蒐集
    public Button Button;

	public GameObject NoteBlock;
	string somekey="finished_state";

    string IsFinalFinsh = "IsFinalFinsh"; //紀錄6_final的按鈕有沒有按過

    private const string P1Key = "P1";
    private const string P2Key = "P2";
    private const string P3Key = "P3";
    private const string P4Key = "P4";
    private const string C1Key = "C1";

    void Start()
    {
		int finished_state=PlayerPrefs.GetInt(somekey,0);
        bool situation = Convert.ToBoolean(PlayerPrefs.GetInt("IsFinalFinsh"));
		if(finished_state>=50){
			NoteBlock.SetActive(false);
		}
		// if(finished_state>=65) NoteBlock.SetActive(true);
        int P1Index = PlayerPrefs.GetInt(P1Key); 
        int P2Index = PlayerPrefs.GetInt(P2Key);
        int P3Index = PlayerPrefs.GetInt(P3Key);
        int P4Index = PlayerPrefs.GetInt(P4Key);
        int C1Index = PlayerPrefs.GetInt(C1Key);

        if(P1Index == 1 && P2Index == 1 && P3Index == 1 && P4Index == 1 && situation == false){
            C1Index = 1;
            Button.interactable = true;
        }
        else{
            C1Index = 0;
            Button.interactable = false;
        }

        Person1.sprite = Person1Sprite[P1Index];
        Person2.sprite = Person2Sprite[P2Index];
        Person3.sprite = Person3Sprite[P3Index];
        Person4.sprite = Person4Sprite[P4Index];
		Person1.SetNativeSize();
		Person2.SetNativeSize();
		Person3.SetNativeSize();
		Person4.SetNativeSize();
		Collected.sprite = IsCollected[C1Index];
    }
}
