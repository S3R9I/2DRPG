﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
using System;
public class EndState : State<StateManager>
{
    private static EndState _instance;
    private EndState()
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static EndState Instance {
        get {
            if (_instance == null)
            {
                
                new EndState();
            }
            return _instance;
        }

    }
    public override void EnterState(StateManager _owner)
    {
        Debug.Log("Entering End State");
    }

    public override void ExitState(StateManager _owner)
    {
        Debug.Log("Exiting End State");
    }

    public override void UpdateState(StateManager _owner)
    {
    }
}
