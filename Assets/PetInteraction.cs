using UnityEngine;
using System.Collections;

public class PetInteraction : MonoBehaviour {
    
    // Use this for initialization
    public string[] dialog;
    public int[] epicness;
    Transform player;
    bool currentlyTalking = false;
    bool firstInteractionDone = false;
    int currentLine = 0;
    UImanager playerUI;
	
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            playerUI = player.GetComponent<UImanager>();
        }

        if (Vector3.Distance(transform.position, player.position) < 2 && !firstInteractionDone)
        {
            firstInteractionDone = true;
            ForcedConversation();
        }       
        

        if (Vector3.Distance(transform.position, player.position) > 3 && currentlyTalking == true)
        {
            currentlyTalking = false;
            playerUI.DisplayDialog("", 0);
        }
    }
    void ForcedConversation()
    {
        if (!currentlyTalking)
        {
            currentLine = 0;
        }
        if (currentLine < dialog.Length)
        {
            currentlyTalking = true;
            playerUI.DisplayDialog(dialog[currentLine], epicness[currentLine]);

            currentLine++;
        }
        else
        {
            playerUI.DisplayDialog("", 0);
            firstInteractionDone = true;
            currentlyTalking = false;
        }
    }
}
