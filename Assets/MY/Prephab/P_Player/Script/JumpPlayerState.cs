using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpPlayerState : IPlayerState
{
    private Player PlayerRef;
    

    public IPlayerState UpdateState(Player _player)
    {
        //chech si le player est revenu a hauteur du sol
        if(PlayerRef.transform.position.y <= 1.1f )
        {
            return new StandingPlayerState();
        }

        return null;
    }

    public void OnEnter(Player _player)
    {
        PlayerRef = _player;
        //Debug.Log("JumpPlayerState - OnEnter");
        //JUMP(_player, _player);
        Jump();
    }

    public void OnExit(Player _player)
    {
        //Debug.Log("JumpPlayerState - OnExit");
    }

    public void Jump()
    {
        Debug.Log("je saute");
        PlayerRef.transform.position += Vector3.up * 1000f * Time.deltaTime;
    }
}