using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNextARState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void setState(int state){
		PlayerPrefs.SetInt("next_state",state);
	}
}
