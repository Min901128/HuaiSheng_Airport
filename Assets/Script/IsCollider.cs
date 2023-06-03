using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class IsCollider : MonoBehaviour{
    public GameObject item;
    public Text CScore;
    private bool IsHasCollider = false;
    private int CorrectScore;
    public UnityEvent CallAddScore;

    private void OnTriggerStay(Collider other){
        //Debug.Log("碰到" + other.tag);
        if(Input.GetMouseButtonUp(0) && IsHasCollider == false){ 
           if(item.tag == "Yes" && other.tag == "Yes"){
                CallAddScore.Invoke();
           } 
           if(item.tag == "No" && other.tag == "No"){
                CallAddScore.Invoke();
            }
            item.SetActive(false);
            IsHasCollider = true;
        }
    }
}