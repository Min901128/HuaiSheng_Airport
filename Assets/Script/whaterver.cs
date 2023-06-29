using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whaterver : MonoBehaviour
{
    public GameObject record;
    public GameObject passport;
    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.DeleteAll();
        int finished_state=PlayerPrefs.GetInt("finished_state",0);
        if(finished_state>=10)passport.SetActive(false);
        if(finished_state>=50)record.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
