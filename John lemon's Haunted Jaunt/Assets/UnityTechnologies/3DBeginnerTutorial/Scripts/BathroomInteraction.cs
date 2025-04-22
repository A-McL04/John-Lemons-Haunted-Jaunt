using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomInteraction : MonoBehaviour
{
    public GameObject dialogueUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Dialogue dialogueBox = dialogueUI.GetComponent<Dialogue>();
            dialogueUI.SetActive(true);
            dialogueBox.StartDialogue();
            
            
        }
    }
}
