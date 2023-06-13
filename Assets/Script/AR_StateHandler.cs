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
		int next_state=PlayerPrefs.GetInt("next_state");
		Debug.Log(next_state);
		if(value_scanned==next_state){
			// goto specific scene
			SceneManager.LoadScene(scene_names[map_playerperf_index_to_scence_index(next_state)], LoadSceneMode.Single);
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
