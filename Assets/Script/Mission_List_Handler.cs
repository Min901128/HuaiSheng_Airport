using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_List_Handler : MonoBehaviour
{
	public GameObject[] missons;
	public string somekey="next_state";
    // Start is called before the first frame update
    void Start()
    {
		if(missons.Length==0)return;
		int next_state=PlayerPrefs.GetInt(somekey,0);
		for (int i = 0; i < missons.Length; i++)
		{
			if(PlayerPrefs.GetInt(somekey+i,0)==1){
				missons[i].SetActive(true);
			}
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
