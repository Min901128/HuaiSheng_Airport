using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StateHandler : MonoBehaviour
{
	public GameObject passed;
	public GameObject not_yet;
	public string[] scene_names;
	float hint_countdown;
	bool counting=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(counting==false)return;
        hint_countdown-=Time.deltaTime;
		if(hint_countdown<0){
			counting=false;
			passed.SetActive(false);
			not_yet.SetActive(false);
		}
    }

	int map_playerperf_index_to_scence_index(int playerperf_index){
		if(playerperf_index==0)return 10;
		if(playerperf_index==1)return 20;
		if(playerperf_index==2)return 30;
		if(playerperf_index==3)return 40;
		if(playerperf_index==4)return 50;
		if(playerperf_index==5)return 61;
		if(playerperf_index==6)return 62;
		if(playerperf_index==7)return 63;
		if(playerperf_index==8)return 64;
		if(playerperf_index==9)return 70;
		if(playerperf_index==10)return 80;
		return 0;
	}

	public void onScanned(int value_scanned){
		Debug.Log(value_scanned);
		int next_state=PlayerPrefs.GetInt("next_state");
		Debug.Log(next_state);
		if(value_scanned==next_state){
			// goto specific scene
			// SceneManager.LoadScene("some_scence_name", LoadSceneMode.Single);
		}
		if(value_scanned>next_state)
		{
			hint_countdown=3f;
			counting=true;
			not_yet.SetActive(true);
		}
		if(value_scanned<next_state)
		{
			hint_countdown=3f;
			counting=true;
			passed.SetActive(true);
		}
	}
}
