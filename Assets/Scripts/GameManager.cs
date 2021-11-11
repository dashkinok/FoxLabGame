using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager ins; //creates static reference to our game manager
    public IVCanvas ivCanvas;
    public ObsCamera obsCamera;
    
    
    [HideInInspector]
    public Node currentNode; //track what node we are currently @

    public CameraRig rig;


    private void Awake()
    {
        ins = this; //lol this is one shitty singleton but this works heheheh
        ivCanvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && currentNode.GetComponent<Prop>() != null) //if you right click and the node is prop is not true then your node changes to the node before
        {
            if (ivCanvas.gameObject.activeInHierarchy)
            {
                ivCanvas.Close();
                return;
            }
            currentNode.GetComponent<Prop>().loc.Arrive();
        }
    }
}
