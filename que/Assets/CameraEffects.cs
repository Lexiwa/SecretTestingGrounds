using UnityEngine;
using System.Collections;

public class CameraEffects : MonoBehaviour {
    float shake;
    bool stopping = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(shake > 0)
        {
            if(stopping)shake -= Time.deltaTime * 3;
            transform.localPosition = Random.insideUnitSphere * shake;
        }
        else
        {
            transform.localPosition = Vector3.zero;
        }
	}
    public void ScreenShake(int s, bool stopAutomatically)
    {
        stopping = stopAutomatically;
        float tmpShake = (float)s / 10;
        if(tmpShake > shake)
        {
            shake = tmpShake;
        }
    }
    
}
