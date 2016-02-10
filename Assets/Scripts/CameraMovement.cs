using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public Transform target;
    private playerMovement playerSpeed;
	// Use this for initialization
	void Start () {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        playerSpeed = playerObject.GetComponent<playerMovement>();
	}
	
	// Update is called once per frame
	void Update () {

        
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y, -10), playerSpeed.speed / 6 * Time.deltaTime);
	}
}
