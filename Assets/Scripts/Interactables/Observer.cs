using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : Interactable
{

    public override void Interact()
    {
        GameObject item = Instantiate(gameObject); //when click on observer and interact, takes go and makes a duplicate
        item.transform.SetParent(GameManager.ins.obsCamera.rig);
        item.transform.localPosition = Vector3.zero;
    }
    
}

//https://www.youtube.com/watch?v=XERmUWwZ1vw&list=PL5KbKbJ6Gf9-rgPHoW8QXn-ZfYQlieSAL&index=14 at 12 min 