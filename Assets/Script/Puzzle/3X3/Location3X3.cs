using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Location3X3 : MonoBehaviour
{    
    //C是Collider
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject C5;
    public GameObject C6;
    public GameObject C7;
    public GameObject C8;
    public GameObject C9;
    public UnityEvent CallFinishManager;
    private bool IsLocation1 = false;
    private bool IsLocation2 = false;
    private bool IsLocation3 = false;
    private bool IsLocation4 = false;
    private bool IsLocation5 = false;
    private bool IsLocation6 = false;
    private bool IsLocation7 = false;
    private bool IsLocation8 = false;
    private bool IsLocation9 = false;
 
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
        //當P5撞到C5
        if(coll.gameObject.tag == "Collider5" && gameObject.tag == "Puzzle5" && IsLocation5 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C5.transform.position;
                Debug.Log("定位完成");
                IsLocation5 = true;
                CallFinishManager.Invoke();
            }
        }
        //當P6撞到C6
        if(coll.gameObject.tag == "Collider6" && gameObject.tag == "Puzzle6" && IsLocation6 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C6.transform.position;
                Debug.Log("定位完成");
                IsLocation6 = true;
                CallFinishManager.Invoke();
            }
        }
        //當P7撞到C7
        if(coll.gameObject.tag == "Collider7" && gameObject.tag == "Puzzle7" && IsLocation7 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C7.transform.position;
                Debug.Log("定位完成");
                IsLocation7 = true;
                CallFinishManager.Invoke();
            }
        }
        //當P8撞到C8
        if(coll.gameObject.tag == "Collider8" && gameObject.tag == "Puzzle8" && IsLocation8 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C8.transform.position;
                Debug.Log("定位完成");
                IsLocation8 = true;
                CallFinishManager.Invoke();
            }
        }
        //當P9撞到C9
        if(coll.gameObject.tag == "Collider9" && gameObject.tag == "Puzzle9" && IsLocation9 == false){
            if(Input.GetMouseButtonUp(0)){
                gameObject.transform.position = C9.transform.position;
                Debug.Log("定位完成");
                IsLocation9 = true;
                CallFinishManager.Invoke();
            }
        }
    }
}
