using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IsCollider : MonoBehaviour{
    public GameObject item;
    private bool IsHasCollider = false;
    
    private void OnTriggerStay(Collider other){   
        //Debug.Log("碰到" + other.tag);
        if(item.tag == "Yes" && other.tag == "Yes" && Input.GetMouseButtonUp(0) && IsHasCollider == false){
            item.SetActive(false);
            IsHasCollider = true;
        }

        if(item.tag == "No" && other.tag == "No" && Input.GetMouseButtonUp(0) && IsHasCollider == false){
            item.SetActive(false);
            IsHasCollider = true;
        }
    }
}