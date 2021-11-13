using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Switcher))]
public abstract class StateReactor: MonoBehaviour
{
   protected Switcher switcher; //protected doesn't appear in inspector/accessed anywhere, child will inherit the switcher
   protected virtual void Awake()
   {
      /*throw new NotImplementedException();*/
      switcher = GetComponent<Switcher>();
   }

   public virtual void React()
   {
      Debug.Log(name + "'s state is" + switcher.state);
   }
}
