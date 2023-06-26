using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosePhoto : MonoBehaviour
{
    public Image Photo;
    public GameObject PhotoForSetActive;
    public Image PhotoOnPassport;
    public GameObject ChoosePanel;
    public GameObject Button;
	public GameObject ButtonTakePicture;

    public void OnButtonClick(){
        PhotoForSetActive.SetActive(true);
        Photo.sprite = GetComponent<Image>().sprite;
        PhotoOnPassport.sprite = GetComponent<Image>().sprite;
        Button.transform.position = new Vector3(1163, 850, 0);
        ChoosePanel.SetActive(false);
		ButtonTakePicture.transform.position = new Vector3(1542, 850, 0);
    }
}
