using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

[SuppressMessage("ReSharper", "RedundantOverriddenMember")]
public class Prop : Node
{
    public Location loc;
    Interactable inter;

    void Awake()
    {
        inter = GetComponent<Interactable>();
    }

    public override void Arrive()
    {
        if (inter != null && inter.enabled)
        {
            inter.Interact();
            return;
        }
        
        base.Arrive();
        
        //make this object interactable if pre-req is met
        if (inter != null)
        {
            if (GetComponent<Prerequisite>() && !GetComponent<Prerequisite>().Complete) //if we have a pre-req on this node and its not completed, then return
            {
                return;
            }
            col.enabled = true;
            inter.enabled = true;
        }
        
    }

    public override void Leave()
    {
        base.Leave();

        if (inter != null)
        {
            inter.enabled = false;
        }
    }
}
