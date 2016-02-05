using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {

    // Use this for initialization
    public Text dialogLine;
    public GameObject panel;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DisplayDialog(string text, int epicness)
    {
        bool stopping = true;
        if(epicness > 10)
        {
            stopping = false;
            epicness -= 10;
        }
        if(text != "")
        {
            panel.SetActive(true);
            dialogLine.text = text;
            Camera.main.GetComponent<CameraEffects>().ScreenShake(epicness, stopping);
        }
        else
        {
            panel.SetActive(false);
            dialogLine.text = "";
            Camera.main.GetComponent<CameraEffects>().ScreenShake(0, true);
        }
    }
}
