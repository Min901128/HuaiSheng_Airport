using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_List_Handler : MonoBehaviour
{
	public GameObject[] missons;
	public GameObject[] btns;
	string somekey="finished_state";
    // Start is called before the first frame update
    void Start()
    {
		closeAllMissions();
		if(missons.Length==0)return;
		int finished_state=PlayerPrefs.GetInt(somekey,0);
		for (int i = 0; i < finished_state/10 + 1; i++)
		{
			btns[i].SetActive(true);
		}
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
