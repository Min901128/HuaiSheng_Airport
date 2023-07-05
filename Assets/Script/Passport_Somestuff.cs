using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Passport_Somestuff : MonoBehaviour
{
    public int toScreenshot;
    public int toShowScreenShot;
    public Image PassportPanel;
	public GameObject PassportBlock;
	string somekey="finished_state";
    // Start is called before the first frame update
    void Start()
    {
		int next_state=PlayerPrefs.GetInt(somekey,0);
		if(next_state>=10) PassportBlock.SetActive(false);
        if(toShowScreenShot==1){
            try
            {
                string filename = Path.Combine(Application.persistentDataPath,"passport.png");
                var rawData = System.IO.File.ReadAllBytes(filename);
                Texture2D tex = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter (she said)
                tex.LoadImage(rawData);
                // int rect_width,rect_height;
                // if(tex.width>=tex.height){
                //     rect_width=tex.height;
                //     rect_height=tex.height;
                // }else{
                //     rect_width=tex.width;
                //     rect_height=tex.width;
                // }
                Sprite sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.zero);
                PassportPanel.sprite=sprite;
            }
            catch (System.Exception)
            {
                // throw;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void screenshot(){
        string path=Path.Combine(Application.persistentDataPath,"passport.png");
        ScreenCapture.CaptureScreenshot(path);
        Debug.Log("Passport Stored in "+path);
    }
}
