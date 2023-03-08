using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using System.Linq;
namespace TOBI.HelloWord1
{
    public class HelloWord : MonoBehaviour
    {
        int a;
        private void Start() 
        {
            a = 6;
            ChangeA(ref a);
            Debug.Log(a);
        }
        void ChangeA(ref int Value) 
        {
            
            Value++;
        }
     
    }

}


