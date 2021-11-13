using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class ColorReactor : StateReactor
{
    public Color active;
    public Color inactive;
    private MeshRenderer mesh;

    protected override void Awake()
    {
        base.Awake();//to make sure we get switcher
        mesh = GetComponentInChildren<MeshRenderer>();
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
