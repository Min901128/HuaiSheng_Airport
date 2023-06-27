using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PhoneCamera : MonoBehaviour 
{
	private bool camAvailable;
	private WebCamTexture backCam;
	private int webcamIndex;
	private int takePhotoCountdown=-1;

	public RawImage background;
	public AspectRatioFitter fit;
	public Dropdown webcamDropdown;
	public GameObject DropdownGameObject;
	public GameObject TakePhotoGameObject;

	List<string> WebCamDeviceNames = new List<string>();

	void Start(){
		WebCamDevice[] devices = WebCamTexture.devices;

		if (devices.Length == 0){
			Debug.Log("No camera detected");
			camAvailable = false;
			return;
		}
		webcamDropdown.ClearOptions();

		for(int i=0;i<devices.Length;i++){
			WebCamDeviceNames.Add(devices[i].name);
			if(devices[i].isFrontFacing){
				backCam=new WebCamTexture(devices[i].name);
				webcamIndex=i;
			}
		}
		backCam=new WebCamTexture(devices[0].name);
		webcamIndex=0;

		webcamDropdown.AddOptions(WebCamDeviceNames);
		webcamDropdown.value=webcamIndex;

		if(backCam==null){
			Debug.Log("Unable to find back camera");
			return;
		}

		backCam.Play();
		background.texture=backCam;
		camAvailable=true;
	}

	void Update(){
		if (!camAvailable) return;

		float ratio = (float)backCam.width / (float)backCam.height;
		fit.aspectRatio = ratio;

		float scaleY = backCam.videoVerticallyMirrored ? -1f: 1f;
		background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

		int orient = -backCam.videoRotationAngle;
		background.rectTransform.localEulerAngles = new Vector3(0,0,orient);

		if(takePhotoCountdown>=0)takePhotoCountdown--;
		if(takePhotoCountdown==0){
			string path=Path.Combine(Application.persistentDataPath,"selfie.png");
			ScreenCapture.CaptureScreenshot(path);
			Debug.Log("Stored in "+path);
			DropdownGameObject.SetActive(true);
			TakePhotoGameObject.SetActive(true);
		}
	}

	private void OnDestroy() {
		backCam.Stop();
	}

	public void changeWebCam(){
		if(webcamDropdown.value==webcamIndex)return;
		backCam.Stop();

		webcamIndex=webcamDropdown.value;
		backCam=new WebCamTexture(WebCamDeviceNames[webcamIndex]);

		if(backCam==null){
			Debug.Log("Unavalible camera:"+WebCamDeviceNames[webcamIndex]);
			camAvailable=false;
			return;
		}

		backCam.Play();
		background.texture=backCam;
		camAvailable=true;
	}

	public void TakePhoto(){
		Debug.Log("Capturing screenshot");
		DropdownGameObject.SetActive(false);
		TakePhotoGameObject.SetActive(false);
		takePhotoCountdown=2;
	}
}
