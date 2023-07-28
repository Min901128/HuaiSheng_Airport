using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DutyFreeLock : MonoBehaviour
{
	string somekey="finished_state";
    // Start is called before the first frame update
    void Start()
    {
        int finished_state=PlayerPrefs.GetInt(somekey,0);
		if(finished_state>=80){
			gameObject.SetActive(false);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
