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

	enum SceneStatusEnum
	{
		GO=0,
		NOTYET=1,
		HAVEBEEN=2
	}

	SceneStatusEnum SceneStatusFn(int value_scanned){
		string P1Key = "P1", P2Key = "P2", P3Key = "P3", P4Key = "P4";
		int[] pnIndex = new int[]{
			PlayerPrefs.GetInt(P1Key),
			PlayerPrefs.GetInt(P2Key),
			PlayerPrefs.GetInt(P3Key),
			PlayerPrefs.GetInt(P4Key)
		};

		int finished_state=PlayerPrefs.GetInt("finished_state",0);

		if(value_scanned/10==6){
			if(finished_state==50) return SceneStatusEnum.GO;
			if(finished_state==60 && pnIndex[value_scanned%10-1]==0) return SceneStatusEnum.GO;
			return SceneStatusEnum.HAVEBEEN;
		}

		if(value_scanned==finished_state+10) return SceneStatusEnum.GO;
		if(value_scanned>finished_state+10) return SceneStatusEnum.NOTYET;
		if(value_scanned<finished_state+10) return SceneStatusEnum.HAVEBEEN;
		
		return SceneStatusEnum.GO;
	}

	public void onScanned(int value_scanned){
		Debug.Log(value_scanned);
		int finished_state=PlayerPrefs.GetInt("finished_state",0);
		Debug.Log(finished_state);
		if(SceneStatusFn(value_scanned)==SceneStatusEnum.GO){
			SceneManager.LoadScene(scene_names[map_playerperf_index_to_scence_index(value_scanned)]);
			return;
		}
		if(SceneStatusFn(value_scanned)==SceneStatusEnum.NOTYET){
			hint_countdown=3f;
			counting=true;
			not_yet.SetActive(true);
			return;
		}
		if(SceneStatusFn(value_scanned)==SceneStatusEnum.HAVEBEEN){
			hint_countdown=3f;
			counting=true;
			passed.SetActive(true);
			return;
		}
	}
}
