using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipMission1Dialogue : MonoBehaviour
{
    private const string Mission1DialogueKey = "Mission1Dialogue";

    public void DialogueSituation(){
        PlayerPrefs.SetInt("Mission1Dialogue", 1);
        PlayerPrefs.Save();
    }
}
