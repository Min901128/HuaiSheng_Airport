using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Handler : MonoBehaviour
{
	public Text Score;
	public GameObject target_sample;
	public GameObject canvas;
	int Score_Points=0;
    // Start is called before the first frame update
    void Start()
    {
		Score.text=Score_Points.ToString();
		createNewTarget();
    }

    // Update is called once per frame
    void Update()
    {

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
