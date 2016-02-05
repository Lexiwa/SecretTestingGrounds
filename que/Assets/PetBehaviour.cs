using UnityEngine;
using System.Collections;

public class PetBehaviour : MonoBehaviour {

    public Transform target;
    public float speed;
    Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y, 0), speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, player.position) > 2)
        {
            transform.Rotate(Vector3.forward * -20);
        }
        else
        {
            transform.Rotate(Vector3.forward * 0);
        }

        //if (Vector3.Distance(transform.position, player.position) < 1 && Input.GetKeyDown(KeyCode.X))
        //{
        //    for(int i = 360; i != 0; i -= 20)
        //    {
        //        transform.Rotate(Vector3.forward * -20);
        //    }
        //}
        if (transform.position.x < target.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
	}
}
