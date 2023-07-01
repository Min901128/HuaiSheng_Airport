using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DutyFreeShop : MonoBehaviour
{
    public Text AmountOfMoney;
    public Text DutyFreeMoney;

    string MoneyKey = "MoneyKey";

    void Start(){
        
    }

    void Update(){
        int Money = PlayerPrefs.GetInt(MoneyKey);
        AmountOfMoney.text = Money.ToString();
    }    
    
    public void MoneyCalculator(GameObject freeshop){
       
        int Money = PlayerPrefs.GetInt(MoneyKey); 

        Money = Money - int.Parse(freeshop.tag);

        PlayerPrefs.SetInt("MoneyKey", Money);
    }

    public void UpdateTheMoneyOfPanel(GameObject freeshop){
        DutyFreeMoney.text = freeshop.tag;
    }
}