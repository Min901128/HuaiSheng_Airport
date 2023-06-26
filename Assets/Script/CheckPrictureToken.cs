using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CheckPrictureToken : MonoBehaviour
{
	public Image PhotoOnPassport;
	public Image Photo;
	public GameObject PhotoForSetActive;
	public Texture2D tex;
	public Sprite sprite;
	public GameObject Button;
	public GameObject PictureChoosePanel;
    // Start is called before the first frame update
    void Start()
    {
		try
		{
			string filename = Path.Combine(Application.persistentDataPath,"selfie.png");
			var rawData = System.IO.File.ReadAllBytes(filename);
			tex = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter (she said)
			tex.LoadImage(rawData);
			int rect_width,rect_height;
			if(tex.width>=tex.height){
				rect_width=tex.height;
				rect_height=tex.height;
			}else{
				rect_width=tex.width;
				rect_height=tex.width;
			}
			sprite = Sprite.Create(tex, new Rect(0, 0, rect_width, rect_height), Vector2.zero);
			Photo.sprite=sprite;
			PhotoOnPassport.sprite=sprite;
			Button.transform.position = new Vector3(1163, 850, 0);
			PhotoForSetActive.SetActive(true);
			transform.position = new Vector3(1542, 850, 0);
		}
		catch (System.Exception)
		{
			
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void TakePictureOnClick(){
		PictureChoosePanel.SetActive(true);
		try
		{
			string filename = Path.Combine(Application.persistentDataPath,"selfie.png");
			var rawData = System.IO.File.ReadAllBytes(filename);
			tex = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter (she said)
			tex.LoadImage(rawData);
			int rect_width,rect_height;
			if(tex.width>=tex.height){
				rect_width=tex.height;
				rect_height=tex.height;
			}else{
				rect_width=tex.width;
				rect_height=tex.width;
			}
			sprite = Sprite.Create(tex, new Rect(0, 0, rect_width, rect_height), Vector2.zero);
			Photo.sprite=sprite;
			PhotoOnPassport.sprite=sprite;
			Button.transform.position = new Vector3(1163, 850, 0);
			PhotoForSetActive.SetActive(true);
			transform.position = new Vector3(1542, 850, 0);
		}
		catch (System.Exception)
		{
			
		}
	}

	public void ClosePictureChoosePanel(){
		PictureChoosePanel.SetActive(false);
	}
}
