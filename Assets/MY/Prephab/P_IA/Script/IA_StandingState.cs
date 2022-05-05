using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_StandingState : IIA
{
    public IIA UpdateState(IA _IA , IPlayerState statePlayer)
    {
        //Ce debug est la pour prouver que je peut connaitre L'etat du player dans n'importe quel State
        //Debug.Log(statePlayer);

        return this;
    }

    // Appeler lorsqu'on entre dans l'état
    public void OnEnter(IA _IA)
    {
        _IA.GetComponent<MeshRenderer>().material = _IA.mStanding;
    }

    // Appeler lorsqu'on sort de l'état
    public void OnExit(IA _IA)
    {

    }
}
