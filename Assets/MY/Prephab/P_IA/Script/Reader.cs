using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reader : MonoBehaviour
{
    public Player player;
    private IPlayerState playerCurrentState;

    void Start()
    {
        
        
    }

    void Update()
    {
        playerCurrentState = player.m_currentState;
        print(playerCurrentState);
    }
}
