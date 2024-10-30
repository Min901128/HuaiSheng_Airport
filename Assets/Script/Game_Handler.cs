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
	public Text FinalScoreText;
	GameObject CurrentTarget;
	int Score_Points = 0;
	float count_down = 30;
	bool is_started = false;
	bool is_ended = false;
	string UFOKey = "UFOKey";

	// Start is called before the first frame update
	void Start()
	{
		Score.text = Score_Points.ToString();
		count_down_text.text = count_down.ToString();
		Game_Start_Obj.SetActive(true);
		Game_End_Obj.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (!is_started || is_ended)
			return;
		if (count_down < 0)
		{
			is_ended = true;
			End_Game();
		}
		count_down -= Time.deltaTime;
		count_down_text.text = Mathf.Ceil(count_down).ToString();
	}

	public void Game_Start()
	{
		Game_Start_Obj.SetActive(false);
		is_started = true;
		createNewTarget();
	}

	public void End_Game()
	{
		Game_End_Obj.SetActive(true);
		FinalScoreText.text = Score_Points.ToString();
		PlayerPrefs.SetInt(UFOKey, Score_Points);
		Destroy(CurrentTarget, 0);
	}

	public void createNewTarget()
	{
		RectTransform rect = this.canvas.GetComponent<RectTransform>();
		var width = rect.rect.width;
		var height = rect.rect.height;

		// Generate random position within the canvas boundaries, adjusted for center pivot
		var randX = Random.Range(-width / 2, width / 2);
		var randY = Random.Range(-height / 2, height / 2);

		CurrentTarget = GameObject.Instantiate(
			target_sample,
			Vector3.zero,
			Quaternion.identity,
			canvas.transform
		);
		CurrentTarget.GetComponent<RectTransform>().localPosition = new Vector3(randX, randY, 0);
		CurrentTarget.SetActive(true);
	}

	public void onTargetClick(GameObject target_clicked)
	{
		Score_Points++;
		Destroy(target_clicked, 0);
		Score.text = Score_Points.ToString();
		if (count_down >= 0)
		{
			createNewTarget();
		}
	}
}
