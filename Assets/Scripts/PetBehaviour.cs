using UnityEngine;
using System.Collections;

public class PetBehaviour : MonoBehaviour {

    public Transform target;
    public float speed;
    public Vector3 playerPos;
    public Vector3 petPos;
    public float distance = 7.5f;
    public Vector3 vect;
    Transform player;
    private SpriteRenderer myRenderer;

	// Use this for initialization
	void Start () {
        myRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        //Stalk the player
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        playerPos = player.position;
        petPos = transform.position;
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x + vect.x, target.position.y + vect.y, 0), speed * Time.deltaTime);
        
        if (Vector3.Distance(petPos, playerPos) > 2)
        {
            transform.Rotate(Vector3.forward * -20);
        }
        else
        {
            transform.Rotate(Vector3.forward * 0);
        }

        //Non-intrusive temmie START

        float dst = Vector3.Distance(target.position, transform.position);
        if (dst < distance)
        {
            vect = target.position - transform.position;
            vect += vect.normalized;
            vect *= (dst - distance);
            transform.position += vect;
        }
        //if (playerPos.x > petPos.x)
        //{
        //    htest = 1.0f;
        //}
        //else if (playerPos.x < petPos.x)
        //{
        //    htest = -1.0f;
        //}
        //if (playerPos.y > petPos.y)
        //{
        //    vtest = 1.0f;
        //}
        //else if (playerPos.y < petPos.y)
        //{
        //    vtest = -1.0f;
        //}
        //if (0 < xdist && xdist < 1.0f && playerPos.y < petPos.y)
        //{
        //    vtest = 1.0f;
        //    htest = 0.0f;
        //}
        //else if (0 > xdist && xdist > 1.0f && playerPos.y > petPos.y)
        //{
        //    vtest = -1.0f;
        //    htest = 0.0f;
        //}

        //Non-intrusive temmie STOP
        if (Vector3.Distance(transform.position, target.position) > 3)
        {
            transform.localScale = new Vector3(4, 4, 1);
        }
        else if (transform.position.x < target.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        myRenderer.sortingOrder = (int)(myRenderer.bounds.min.y * -10);
    }
}
