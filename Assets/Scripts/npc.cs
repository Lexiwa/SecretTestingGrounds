using UnityEngine;
using System.Collections;

public class npc : MonoBehaviour {

    // Use this for initialization
    public string[] dialog;
    public int[] Epicness;
    Transform player;
    bool currentlyTalking = false;
    int currentLine = 0;
    UImanager playerUI;
    void Start () {
        SpriteRenderer myRenderer = GetComponent<SpriteRenderer>();
        myRenderer.sortingOrder = (int)(myRenderer.bounds.min.y * -10);
    }

	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            playerUI = player.GetComponent<UImanager>();
        }
        if(Vector3.Distance(transform.position, player.position) < 2 && Input.GetKeyDown(KeyCode.Z))
        {
            Interact();
        }
        if (Vector3.Distance(transform.position, player.position) > 3 && currentlyTalking == true)
        {
            currentlyTalking = false;
            playerUI.DisplayDialog("", 0);
        }
    }
    void Interact()
    {
        if(!currentlyTalking)
        {
            currentLine = 0;
        }
        if (currentLine < dialog.Length)
        {
            currentlyTalking = true;
            playerUI.DisplayDialog(dialog[currentLine], Epicness[currentLine]);

            currentLine++;
        }
        else
        {
            playerUI.DisplayDialog("", 0);
            currentlyTalking = false;
        }
    }
}
