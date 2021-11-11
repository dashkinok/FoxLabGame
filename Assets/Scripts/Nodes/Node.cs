using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public abstract class Node : MonoBehaviour
{
    public Transform cameraPos;
    public List<Node> reachableNodes = new List<Node>();

    [HideInInspector]
    public Collider col;
    
    void Start() // Start is called before the first frame update
    {
        col = GetComponent<Collider>();
    }
    void OnMouseDown() //when you click with your mouse x happens
    {
       Arrive();
    }
    public virtual void Arrive() //virtual - when at a ndoe we can still call arrive, but with a chance of it being overriden
    {
        //leave existing currentNode
        if(GameManager.ins.currentNode != null)
            GameManager.ins.currentNode.Leave();
        
        //set currentNode
        GameManager.ins.currentNode = this;
        
        //move the camera
        GameManager.ins.rig.AlignTo(cameraPos);
        
        
        // snaps camera to the position 
            // Camera.main.transform.position = cameraPos.position;
            // Camera.main.transform.rotation = cameraPos.rotation;
        
        //turn off our own collider
        
        if (col != null) //if it doesn't = null, then we turn it off/set it to false
            col.enabled = false;

        //turn on all reachable node colliders
        foreach (Node node in reachableNodes) //for each node we check if there is a collider, if there is a collider - then enable it
        {
            if (node.col != null)
            {
                node.col.enabled = true;
            }
        }
    }

    public virtual void Leave()
    {
        //turn off all reachable node colliders
        foreach (Node node in reachableNodes) //for each node we check if there is a collider, if there is a collider - then enable it
        {
            if (node.col != null)
            {
                node.col.enabled = false;
            }
        }
    }
    
}
