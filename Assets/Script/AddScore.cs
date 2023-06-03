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
   
    private int CorrectScore;
    void Start() {
        CorrectScore = int.Parse(CScore.text);
    }

    void Update(){
        if(!item1.activeSelf && !item2.activeSelf && !item3.activeSelf && !item4.activeSelf && !item5.activeSelf && !item6.activeSelf){
            FinishPanel.SetActive(true);
        }
    }

    public void AddScoreFunction(){
        CorrectScore++;
        string CScore_String = CorrectScore.ToString();
        CScore.text = CScore_String;
    }
}
