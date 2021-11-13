using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prerequisite : MonoBehaviour
{
  public Switcher watchSwitcher; //switcher that we are watching to see what state it is in
  public bool nodeAccess; //check if the pre-req is actually accessing the node


  public bool Complete //check var in switcher, see if state is T/F
  
  
  {
    get {return watchSwitcher.state;} //make sure that everything becomes TRUE from false once its condition is met
  }
}
