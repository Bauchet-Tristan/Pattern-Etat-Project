using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState 
{
    // Executer a chaque frame prend en variable "Player" et retourne un IPlayerState
    IPlayerState UpdateState(Player _player);

    // Appeler lorsqu'on entre dans l'état
    void OnEnter(Player _player);

    // Appeler lorsqu'on sort de l'état
    void OnExit(Player _player);
}


