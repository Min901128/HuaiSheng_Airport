using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhoneCameraForUAR : MonoBehaviour
{
	private int takePhotoCountdown=-1;
	public GameObject TakePhotoGameObject;
	public GameObject LastPage;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update(){
		if(takePhotoCountdown>=0)takePhotoCountdown--;
		if(takePhotoCountdown==0){
			string path=Path.Combine(Application.persistentDataPath,"selfie.png");
			ScreenCapture.CaptureScreenshot(path);
			Debug.Log("Stored in "+path);
			TakePhotoGameObject.SetActive(true);
			LastPage.SetActive(true);
		}
	}

	public void TakePhoto(){
		Debug.Log("Capturing screenshot");
		TakePhotoGameObject.SetActive(false);
		LastPage.SetActive(false);
		takePhotoCountdown=2;
	}
}
