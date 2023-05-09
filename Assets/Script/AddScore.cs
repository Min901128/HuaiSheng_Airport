using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;

    public Text CScore;

    public GameObject FinishPanel;
   
    //每個物件是不是第一次可見為假
    private bool a1 = false, a2 = false, a3 = false, a4 = false, a5 = false, a6 = false;
    private int CorrectScore;
    void Start() {
        CorrectScore = int.Parse(CScore.text);
    }

    void Update(){
        if(!item1.activeSelf && a1 == false){
            AddScoreFunction();
            a1 = true;
            Debug.Log(CScore.text);
        }

        if(!item2.activeSelf && a2 == false){
            AddScoreFunction();
            a2 = true;
            Debug.Log(CScore.text);
        }

        if(!item3.activeSelf && a3 == false){
            AddScoreFunction();
            a3 = true;
            Debug.Log(CScore.text);
        }

        if(!item4.activeSelf && a4 == false){
            AddScoreFunction();
            a4 = true;
            Debug.Log(CScore.text);
        }

        if(!item5.activeSelf && a5 == false){
            AddScoreFunction();
            a5 = true;
            Debug.Log(CScore.text);
        }

        if(!item6.activeSelf && a6 == false){
            AddScoreFunction();
            a6 = true;
            Debug.Log(CScore.text);
        }

        if(a1 && a2 && a3 && a4 && a5 && a6){
            FinishPanel.SetActive(true);
        }
    }

    void AddScoreFunction(){
        CorrectScore++;
        string CScore_String = CorrectScore.ToString();
        CScore.text = CScore_String;
    }
}
