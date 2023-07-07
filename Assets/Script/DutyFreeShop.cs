using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DutyFreeShop : MonoBehaviour
{
    public Text AmountOfMoney;
    public Text DutyFreeMoney;

    public GameObject NotEnoughPanel;

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

    string MoneyKey = "MoneyKey";

    int Money;

    public HaveYouEverBought HaveYouEverBought;

    void Update(){
        Money = PlayerPrefs.GetInt(MoneyKey);
        AmountOfMoney.text = Money.ToString();
    }    
    
    public void MoneyCalculator(GameObject freeshop){
        int DutyFreePrice = int.Parse(freeshop.tag);
        int CurrentMoney = int.Parse(AmountOfMoney.text);
        
        if(CurrentMoney >= DutyFreePrice){
            int Money = PlayerPrefs.GetInt(MoneyKey); 

            Money = Money - int.Parse(freeshop.tag);

            PlayerPrefs.SetInt("MoneyKey", Money);

            if(freeshop.tag == "50"){
                HaveYouEverBought.Record1();
                //把50塊的可見關掉
                S1.SetActive(false);
                T1.SetActive(false);
                K1.SetActive(false);
                Price1.SetActive(false);
            }
            else if(freeshop.tag == "100"){
                HaveYouEverBought.Record2();
                //把100塊的可見關掉
                S2.SetActive(false);
                T2.SetActive(false);
                K2.SetActive(false);
                Price2.SetActive(false);
            }
            else{
                HaveYouEverBought.Record3();
                //把150塊的可見關掉
                S3.SetActive(false);
                T3.SetActive(false);
                K3.SetActive(false);
                Price3.SetActive(false);
            }
        }
        else{
            NotEnoughPanel.SetActive(true);
        }       
    }

    public void UpdateTheMoneyOfPanel(GameObject freeshop){
        DutyFreeMoney.text = freeshop.tag;
    }

    /*public void Start(){
        PlayerPrefs.SetInt("MoneyKey", 300);
    }*/
}