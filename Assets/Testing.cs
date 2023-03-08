using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TOBI.HelloWord1;
using TOBI.HelloWord2;
using System.Linq;
using System;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class Testing : MonoBehaviour
{
    int a;
    int b;
    private void Start()
    {
        a = 10;
        b = 15;

        do 
        {
            a++;
            b += a;
            Debug.Log($"a = {a}, b = {b}");
        }
        while((a+b)<20);

    }
}




