using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public Transform target;
    public float speed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y, -10), speed * Time.deltaTime);
	}
}
