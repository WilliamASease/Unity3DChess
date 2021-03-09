using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameLord : MonoBehaviour
{
    State currentState;
    
    void Start()
    {
        currentState = new InitialState();
        currentState.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Transition(State a)
    {
        currentState = a;
        a.Read();
    }
}
