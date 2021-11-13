using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : Interactable
{
  public bool state;

  public override void Interact()
  {
    state = !state; //whenver we interract with a state it changes another state. if state is true-becomes false
    if (GetComponent<StateReactor>() != null)
    {
      GetComponent<StateReactor>().React();
    }
  }
}
