using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_AggroState : IIA
{
    public IIA UpdateState(IA _IA, IPlayerState statePlayer)
    {
        // Ce debug est la pour prouver que je peut connaitre L'etat du player dans n'importe quel State
        //Debug.Log(statePlayer);
        /*if (_IA.transform.position.y <= 1.1f)
        {
            _IA.transform.position += Vector3.up * 1000f * Time.deltaTime;
        }
        */
        return this;
    }

    // Appeler lorsqu'on entre dans l'état
    public void OnEnter(IA _IA)
    {
        _IA.GetComponent<MeshRenderer>().material = _IA.mAggro;

    }

    // Appeler lorsqu'on sort de l'état
    public void OnExit(IA _IA)
    {

    }
}
