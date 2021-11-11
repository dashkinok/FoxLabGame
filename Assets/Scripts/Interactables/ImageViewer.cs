using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageViewer : Interactable //tells image canvas to turn on
{
    public Sprite pic;
    public override void Interact()
    {
        GameManager.ins.ivCanvas.Activate(pic);
    }
}
