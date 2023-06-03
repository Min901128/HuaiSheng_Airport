using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject PP5;
    
    private float x1 = 830.0f, y1 = 670.0f, x2 = 1090.0f, y2 = 670.0f;
    private float x3 = 830.0f, y3 = 410.0f, x4 = 1090.0f, y4 = 410.0f;
    private float z = 0.0f;

    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        //Debug.Log("發生碰撞");
        if(Input.GetMouseButtonUp(0)){
            PP5.transform.position = new Vector3(x1, y1, z);
        }
    }
}
