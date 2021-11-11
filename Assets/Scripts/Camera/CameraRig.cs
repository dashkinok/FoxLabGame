using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraRig : MonoBehaviour
{
    public Transform y_axis; 
    public Transform x_axis;
    public float moveTime;

    public void AlignTo(Transform target)
    {
        //move the camera using the dotween addon 
        Sequence seq = DOTween.Sequence();
        seq.Append(y_axis.DOMove     (target.position,0.75f)); //lets us move transform from place to place using end value (camera pos) and duration (3/4s)
        seq.Join  (y_axis.DORotate(new Vector3(0f,target.rotation.eulerAngles.y,0f), 0.75f)); //DORotate wants to use V3 instead of just rotation, we convert it by using eurler angles 
        seq.Join  (x_axis.DOLocalRotate(new Vector3(target.rotation.eulerAngles.x, 0f,0f), 0.75f)); //DORotate wants to use V3 instead of just rotation, we convert it by using eurler angles 

    }
}
