using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Handler : MonoBehaviour
{
	public Text Score;
	public Text count_down_text;
	public GameObject target_sample;
	public GameObject canvas;
	public GameObject Game_Start_Obj;
	public GameObject Game_End_Obj;
	int Score_Points=0;
	float count_down=30;
	bool is_started=false;
	bool is_ended=false;
    // Start is called before the first frame update
    void Start()
    {
		Score.text=Score_Points.ToString();
		count_down_text.text=count_down.ToString();
		Game_Start_Obj.SetActive(true);
		Game_End_Obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if(is_started==false)return;
		if(is_ended==true)return;
		if(count_down<0){
			is_ended=true;
			End_Game();
		}
		count_down-=Time.deltaTime;
		count_down_text.text=Mathf.Ceil(count_down).ToString();
    }

	public void Game_Start(){
		Game_Start_Obj.SetActive(false);
		is_started=true;
		createNewTarget();
	}

	public void End_Game(){
		Game_End_Obj.SetActive(true);
	}

	public void createNewTarget()
	{
		GameObject.Instantiate(
			target_sample,
			new Vector3(Random.Range(0, 1920),Random.Range(0, 1080), 0),
			Quaternion.identity,
			canvas.transform
		).SetActive(true);
	}

	public void onTargetClick(GameObject target_clicked)
	{
		Score_Points++;
		Destroy(target_clicked,0);
		Score.text=Score_Points.ToString();
		createNewTarget();
	}
}
