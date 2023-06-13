using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DutyFreeShop : MonoBehaviour
{
    public Text Money;
    public Text Panel_Comform_Text_CostMoney;
    public Text CurrentMoney;
    public GameObject ComfirmButton;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdateComfirmPanel(){
        Panel_Comform_Text_CostMoney.text = Money.text;
        ComfirmButton.SetActive(true);
    }

    public void MoneyCalculator(int ButtonTag){
        int NumberOfMoney = int.Parse(CurrentMoney.text);

        if(ButtonTag == 1){
            NumberOfMoney = NumberOfMoney - 500;
        }
        else if(ButtonTag == 2){
            NumberOfMoney = NumberOfMoney - 1000;
        }
        else if(ButtonTag == 3){
            NumberOfMoney = NumberOfMoney - 3000;
        }
        else if(ButtonTag == 4){
            NumberOfMoney = NumberOfMoney -1000;
        }
        else if(ButtonTag == 5){
            NumberOfMoney = NumberOfMoney - 300;
        }
        else{
            NumberOfMoney = NumberOfMoney - 800;
        }

        CurrentMoney.text = NumberOfMoney.ToString();
    }
}
