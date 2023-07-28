using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakePassport : MonoBehaviour
{
    public Text Name;
    public Text Nationality;
    public Text Sex;
    public Text BirthPlace;
    public Text BirthDay;

    public Text YourName;
    public Text YourNationality;
    public Text YourSex;
    public Text YourBirthPlace;
    public Text YourBirthDay;

	string PassportNameKey = "PassportNameKey";
    
    public void ShowData(){
        YourName.text = Name.text;
        YourNationality.text = Nationality.text;
        YourSex.text = Sex.text;
        YourBirthPlace.text = BirthPlace.text;
        //YourBirthDay.text = BirthDay.text;
		PlayerPrefs.SetString(PassportNameKey, Name.text);
    }
}
