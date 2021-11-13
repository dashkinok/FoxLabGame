// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class Observer : Interactable
// {
//     public override void Interact()
//     {
//         GameObject item = Instantiate(gameObject); //when click on observer and interact, takes go and makes a duplicate
//         item.transform.SetParent(GameManager.ins.obsCamera.rig);
//         item.transform.localPosition = Vector3.zero;
//         item.transform.GetChild(0).transform.localPosition = Vector3.zero;
//         GameManager.ins.obsCamera.model = item.transform; 
//         GameManager.ins.obsCamera.gameObject.SetActive(true);
//     }
//     
// }
//
