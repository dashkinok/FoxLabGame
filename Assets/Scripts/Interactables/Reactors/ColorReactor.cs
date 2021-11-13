using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))] //make sure the object that we change color of has a MESH 
public class ColorReactor : StateReactor
{
    public Color active;
    public Color inactive;
    private MeshRenderer mesh;

    protected override void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        base.Awake();//to make sure we get switcher
        React();
        
    }
    public override void React()
    {
        if (switcher.state)
        {
            mesh.material.color = active;
        }
        else
        {
            mesh.material.color = inactive;
        }
    }
}
