using UnityEngine;
using System.Collections;

public class AMovementThingYes : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}
    Rigidbody2D rb;
    float spd = 7;
    bool isMoving = false;
    // Update is called once per frame

    void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isMoving = true;
            rb.AddForce(new Vector2(0, 12));
            //transform.Translate(Vector3.up * spd * Time.deltaTime);
            spd = 7;
        }
        if (Input.GetKey(KeyCode.A))
        {
            isMoving = true;
            rb.AddForce(new Vector2(-12, 0));
            //transform.Translate(Vector3.left * spd * Time.deltaTime);
            spd = 7;
        }
        if (Input.GetKey(KeyCode.S))
        {
            isMoving = true;
            rb.AddForce(new Vector2(0, -12));
            //transform.Translate(Vector3.down * spd * Time.deltaTime);
            spd = 7;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(12, 0));
            //transform.Translate(Vector3.right * spd * Time.deltaTime);
            spd = 7;
        }
    }
}
