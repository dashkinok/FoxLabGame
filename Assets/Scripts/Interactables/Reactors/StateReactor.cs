using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateReactor: MonoBehaviour
{
   public Switcher switcher;
   
   protected virtual void Awake()
   {
      switcher.Change += React; //adding react f() to the event, if event happens, so does the react f (we are referring to the fxn)
   }

   public virtual void React()
   {
      Debug.Log(name + "'s state is" + switcher.state);
   }
}
