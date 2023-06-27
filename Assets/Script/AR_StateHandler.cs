using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AR_StateHandler : MonoBehaviour
{
	public GameObject passed;
	public GameObject not_yet;
	public string[] scene_names;
	float hint_countdown;
	bool counting=false;
	// Start is called before the first frame update
	void Start()
	{
		// SetFinishedARState(0);
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

	public void SetFinishedARState(int state){
		PlayerPrefs.SetInt("finished_state",state);
		PlayerPrefs.Save();
	}

	int map_playerperf_index_to_scence_index(int playerperf_index){
		if(playerperf_index==10)return 0;
		if(playerperf_index==20)return 1;
		if(playerperf_index==30)return 2;
		if(playerperf_index==40)return 3;
		if(playerperf_index==50)return 4;
		if(playerperf_index==61)return 5;
		if(playerperf_index==62)return 6;
		if(playerperf_index==63)return 7;
		if(playerperf_index==64)return 8;
		if(playerperf_index==70)return 9;
		if(playerperf_index==80)return 10;
		return 0;
	}

	public void onScanned(int value_scanned){
		Debug.Log(value_scanned);
		int finished_state=PlayerPrefs.GetInt("finished_state",0);
		Debug.Log(finished_state);
		if(finished_state==60 && value_scanned/10==6)
		{
			SceneManager.LoadScene(scene_names[map_playerperf_index_to_scence_index(value_scanned)]);
		}
		if(finished_state==60)
		{
			string P1Key = "P1";
			string P2Key = "P2";
			string P3Key = "P3";
			string P4Key = "P4";
			int P1Index = PlayerPrefs.GetInt(P1Key); 
			int P2Index = PlayerPrefs.GetInt(P2Key);
			int P3Index = PlayerPrefs.GetInt(P3Key);
			int P4Index = PlayerPrefs.GetInt(P4Key);
			if(P1Index==1 && P2Index==1 && P3Index==1 && P4Index==1){
				SceneManager.LoadScene(scene_names[map_playerperf_index_to_scence_index(value_scanned)]);
			}else{
				hint_countdown=3f;
				counting=true;
				not_yet.SetActive(true);
			}
			return;
		}
		if(finished_state==50 && value_scanned/10==6)
		{
			SceneManager.LoadScene(scene_names[map_playerperf_index_to_scence_index(value_scanned)]);
		}

		if(value_scanned==finished_state+10)
		{
			SceneManager.LoadScene(scene_names[map_playerperf_index_to_scence_index(value_scanned)]);
		}
		if(value_scanned>finished_state+10)
		{
			hint_countdown=3f;
			counting=true;
			not_yet.SetActive(true);
		}
		if(value_scanned<finished_state+10)
		{
			hint_countdown=3f;
			counting=true;
			passed.SetActive(true);
		}
	}
}
