﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
using System;
public class PlayState : State<State_Manager>
{
    private static PlayState _instance;

    private PlayState()
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static PlayState Instance
    {
        get {
            if(_instance == null)
            {
                new PlayState();
            }
            return _instance;
        }

    }
    public override void EnterState(State_Manager _owner)
    {
        Debug.Log("Entering Play State");
    }

    public override void ExitState(State_Manager _owner)
    {
        Debug.Log("Exiting Play State");
    }


    public override void UpdateState(State_Manager _owner)
    {
        //    _owner.stateMachine.ChangeState(EndState.Instance);
    }
}
