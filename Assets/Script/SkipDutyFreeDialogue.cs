using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipDutyFreeDialogue : MonoBehaviour
{
    private const string DutyFreeDialogueKey = "DutyFreeDialogue";

    public void DialogueSituation(){
        PlayerPrefs.SetInt("DutyFreeDialogue", 1);
        PlayerPrefs.Save();
    }
}