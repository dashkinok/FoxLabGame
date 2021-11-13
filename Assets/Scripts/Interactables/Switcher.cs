using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : Interactable
{
  public bool state;

  //event setup
  //delegate is a var where you put a f() instead of a piece of info into it
  //delegates define what bool or int are going to be, here it defines what a f() is going to be. f()s that are going to use this delegate will need to follow these rules
  public delegate void OnStateChange(); //any f() that falls under this is not going to return anything and it req. no parameters (simplest version)
  public event OnStateChange Change; //Event itself, the event is the type of the delegate //not a f() call, it is the name of our event 

  public override void Interact()
  {
    state = !state; //whenever we interact with a state it changes another state. if state is true-becomes false
    if (Change != null) {
        Change(); //any f() in change should fire now (almost like list, can add/subtract, remove)
    }
    {
      
    }
  }
}
