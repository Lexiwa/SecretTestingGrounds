using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

private SpriteRenderer myRenderer;

    public float speed;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        myRenderer = GetComponent<SpriteRenderer>();
        
	}
    Rigidbody2D rb;
    // Update is called once per frame

    void Update ()
    {
        speed = 12;
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 16;
        }


        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(speed * -1, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, speed * -1));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed, 0));
        }

        myRenderer.sortingOrder = (int)(myRenderer.bounds.min.y * -10);
    }
}
