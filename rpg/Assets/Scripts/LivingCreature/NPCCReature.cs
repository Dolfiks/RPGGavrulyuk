using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCReature : Interactable
{
    protected override void Interact()
    {
        base.Interact();
        Debug.Log("Hi Bro, go to chat");
    }
}
