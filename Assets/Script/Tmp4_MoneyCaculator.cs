using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tmp4_MoneyCaculator : MonoBehaviour
{
    public GameObject Panel_ComfirmBuy1;
    public GameObject Panel_ComfirmBuy2;
    public GameObject Panel_NotEnough;
    public GameObject Item1, Item2, Item3;

    public Button Button_Dialogue;

    string MoneyKey = "MoneyKey";

    int Money;

    public Chat_Event_Mission4 Chat_Event_Mission4;

    public void MoneyCalculator(GameObject Item){
        Money = PlayerPrefs.GetInt(MoneyKey); 
        int ItemPrice = int.Parse(Item.tag);
        
        if(Money < ItemPrice){
            //錢不夠，把錢不夠的panel打開
            Panel_NotEnough.SetActive(true);

            //Debug.Log("錢不夠");
        }
        else{

            //把確認的Panel關掉、撲克牌面膜不用謝謝的可見也要關掉
            Panel_ComfirmBuy1.SetActive(false);
            Panel_ComfirmBuy2.SetActive(false);
            Item1.SetActive(false);
            Item2.SetActive(false);
            Item3.SetActive(false);

            //扣錢
            Money = Money - ItemPrice;
            PlayerPrefs.SetInt("MoneyKey", Money);
            //把Button_Dialogue的interactable設為真
            Button_Dialogue.interactable = true;
            //按鈕上掛Chat_Event_Mission4.AddIndex
            Chat_Event_Mission4.AddIndex();
        }


    }
}
