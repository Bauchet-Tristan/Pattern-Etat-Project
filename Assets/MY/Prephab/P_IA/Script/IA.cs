using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    // On creer une variable "m_currentState" de type "IPlayerState" qui sert a connaitre l'etat actuel du Player
    public IIA ia_currentState;
    public Player _player;
    public Material mAggro;
    public Material mStanding;

    private void Start()
    {
        ia_currentState = new IA_StandingState();
    }

    private void Update()
    {
        //Actualise l'état a chaque frame
        var nextState = ia_currentState.UpdateState(this, Reader(_player));
        Debug.Log(nextState);
        
        // Si "nextState est different de "null" on sort de l'etat actuel pour rentrer dans celui qui est dans nextState 
        if (nextState != null)
        {
            ia_currentState.OnExit(this);
            ia_currentState = nextState;
            ia_currentState.OnEnter(this);
        }

        // Compare l'etat actuel du joueur au etat potentiel et change l'etat de L'IA en fonction.
        // Le is remplace les "==" pour comparer des Interface avec leur enfant
        if (Reader(_player) is JumpPlayerState)
        {
            ia_currentState = new IA_AggroState();
        }
        else
        {
            ia_currentState = new IA_StandingState();
        }

    }

    public IPlayerState Reader(Player _player)
    {
        return _player.m_currentState;
    }

    private void OnGUI()
    {
        var centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 500, 50), "IA state = " + ia_currentState.ToString(), centeredStyle);
    }
}