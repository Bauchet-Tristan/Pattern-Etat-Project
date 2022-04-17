using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StandingPlayerState : IPlayerState
{
    private IPlayerState m_nextState;

    public IPlayerState UpdateState(Player _player)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("le je veux sauté");
            return new JumpPlayerState();
        }

        return null;
    }

    public void OnEnter(Player _player)
    {
        //Debug.Log("StandingPlayerState - OnEnter");
    }

    public void OnExit(Player _player)
    {
        //Debug.Log("StandingPlayerState - OnExit");
    }
 
}
