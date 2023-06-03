using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Location2X2 : MonoBehaviour
{    
    //C是Collider
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public UnityEvent CallFinishManager;

    private bool IsLocation1 = false;
    private bool IsLocation2 = false;
    private bool IsLocation3 = false;
    private bool IsLocation4 = false;
    void OnCollisionStay2D(Collision2D coll)
    {
        Debug.Log("與" + coll.gameObject.tag + "發生碰撞");
        //當P1撞到C1
        if(coll.gameObject.tag == "Collider1" && gameObject.tag == "Puzzle1" && IsLocation1 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C1.transform.position;
                Debug.Log("定位完成");
                IsLocation1 = true;
                CallFinishManager.Invoke();
            }
        }
        //當P2撞到C2
        if(coll.gameObject.tag == "Collider2" && gameObject.tag == "Puzzle2" && IsLocation2 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C2.transform.position;
                Debug.Log("定位完成");
                IsLocation2 = true;
                CallFinishManager.Invoke();
            }
        }
        //當P3撞到C3
        if(coll.gameObject.tag == "Collider3" && gameObject.tag == "Puzzle3" && IsLocation3 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C3.transform.position;
                Debug.Log("定位完成");
                IsLocation3 = true;
                CallFinishManager.Invoke();
            }
        }
        //當P4撞到C4
        if(coll.gameObject.tag == "Collider4" && gameObject.tag == "Puzzle4" && IsLocation4 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C4.transform.position;
                Debug.Log("定位完成");
                IsLocation4 = true;
                CallFinishManager.Invoke();
            }
        }
    }
}
