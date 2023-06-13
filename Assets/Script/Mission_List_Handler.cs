using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_List_Handler : MonoBehaviour
{
	public GameObject[] missons;
    // Start is called before the first frame update
    void Start()
    {
        closeAllMissions();
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
