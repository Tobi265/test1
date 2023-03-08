using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bt1 : MonoBehaviour
{

    string s1 = "abc1 ";
    string s2 = "abc2";

    enum GameState
    {
        Starting ,
        Playing ,
        Win ,
        Gameover 
    }
    
    
    void Start()
    {
        Debug.Log((GameState)1);
 
    }

}
