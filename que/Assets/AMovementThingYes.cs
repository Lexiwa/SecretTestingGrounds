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
    public static bool playerHasControl = true;
    // Update is called once per frame

    void Update ()
    {
        if (Input.GetKey(KeyCode.W) && playerHasControl)
        {
            isMoving = true;
            rb.AddForce(new Vector2(0, 12));
            spd = 7;
        }
        if (Input.GetKey(KeyCode.A) && playerHasControl)
        {
            isMoving = true;
            rb.AddForce(new Vector2(-12, 0));
            spd = 7;
        }
        if (Input.GetKey(KeyCode.S) && playerHasControl)
        {
            isMoving = true;
            rb.AddForce(new Vector2(0, -12));
            spd = 7;
        }
        if (Input.GetKey(KeyCode.D) && playerHasControl)
        {
            rb.AddForce(new Vector2(12, 0));
            spd = 7;
        }
    }

}
