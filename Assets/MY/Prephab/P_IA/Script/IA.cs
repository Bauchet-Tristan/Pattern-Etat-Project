using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    // On creer une variable "m_currentState" de type "IPlayerState" qui sert a connaitre l'etat actuel du Player
    public IIA ia_currentState;
    public Player _player;
    private void Start()
    {
        ia_currentState = new IA_StandingState();
    }

    private void Update()
    {
        //Actualise l'état a chaque frame
        var nextState = ia_currentState.UpdateState(this, Reader(_player));
        
        // Si "nextState est different de "null" on sort de l'etat actuel pour rentrer dans celui qui est dans nextState 
        if (nextState != null)
        {
            ia_currentState.OnExit(this);
            ia_currentState = nextState;
            ia_currentState.OnEnter(this);
        }

        // Compare l'etat actuel du joueur au etat potentiel et change l'etat de L'IA en fonction.
        // Le is remplace les "==" pour comparer des Interface avec leur enfant
        if (Reader(_player) is StandingPlayerState)
        {
            ia_currentState = new IA_StandingState();
        }
        else
        {
            ia_currentState = new IA_AggroState();
        }

    }

    public IPlayerState Reader(Player _player)
    {
        return _player.m_currentState;
    }
}