using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsFinish2X2 : MonoBehaviour
{
    public GameObject Panel;
    private int finish = 0;
    public void FinishCaculator(){
        finish++;
        if(finish == 4){
            Panel.SetActive(true);
        }
        Debug.Log("已完成" + finish + "片拼圖");
    } 
}
