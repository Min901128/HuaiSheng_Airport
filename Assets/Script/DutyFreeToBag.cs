using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; 

public class DutyFreeToBag : MonoBehaviour
{
    public GameObject D1;//DutyFree1GameObject
	public GameObject D2;
	public GameObject D3; 

    public Text CurrentMoney;
	public Text Country_Name;

    string MessageKey = "Country", MoneyKey="MoneyKey";

    private const string DutyFree1Key = "DutyFree1";
    private const string DutyFree2Key = "DutyFree2";
    private const string DutyFree3Key = "DutyFree3";

    void Start()
    {
        bool situation1 = Convert.ToBoolean(PlayerPrefs.GetInt("DutyFree1"));
		bool situation2 = Convert.ToBoolean(PlayerPrefs.GetInt("DutyFree2"));
		bool situation3 = Convert.ToBoolean(PlayerPrefs.GetInt("DutyFree3"));

        D1.SetActive(situation1);
		D2.SetActive(situation2);
		D3.SetActive(situation3);

		if(CurrentMoney) CurrentMoney.text = PlayerPrefs.GetInt("MoneyKey").ToString();
		if (Country_Name) Country_Name.text = PlayerPrefs.GetString("Country");
    }
}
