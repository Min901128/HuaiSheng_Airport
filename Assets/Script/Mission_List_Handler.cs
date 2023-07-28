using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_List_Handler : MonoBehaviour
{
	public GameObject[] missons;
	public GameObject[] btns;
	public GameObject[] arrows;
	string somekey="finished_state";
    // Start is called before the first frame update
    void Start()
    {
		foreach (var arrow in arrows)
		{
			arrow.SetActive(false);
		}
		closeAllMissions();
		if(missons.Length==0)return;
		int finished_state=PlayerPrefs.GetInt(somekey,0);
		int PanelCount=finished_state/10 + 1;
		if(finished_state==60) PanelCount--;
		for (int i = 0; i < PanelCount; i++)
		{
			btns[i].SetActive(true);
		}
		arrows[PanelCount-1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void closeAllMissions(){
		foreach (var mission in missons)
		{
			mission.SetActive(false);
		}
	}

	public void openMission(int id){
		closeAllMissions();
		missons[id].SetActive(true);
	}
}
