using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IIA
{
    IIA UpdateState(IA _IA, IPlayerState statePlayer);

    // Appeler lorsqu'on entre dans l'�tat
    void OnEnter(IA _IA);

    // Appeler lorsqu'on sort de l'�tat
    void OnExit(IA _IA);
}
