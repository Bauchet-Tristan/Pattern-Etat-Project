using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // On creer une variable "m_currentState" de type "IPlayerState" qui sert a connaitre l'etat actuel du Player
    public IPlayerState m_currentState;
    private float speed = 3f;

    private void Start()
    {
        //Affecte "StandingPlayerState" pour l'etat primaire
        m_currentState = new StandingPlayerState();
    }

    private void Update()
    {
        //Actualise l'état a chaque frame
        var nextState = m_currentState.UpdateState(this);
        // Si "nextState est "null" on sort de l'etat actuel pour rentrer dans celui qui est dans nextState 
        if (nextState != null)
        {
            m_currentState.OnExit(this);
            m_currentState = nextState;
            m_currentState.OnEnter(this);
        }

       // Movement();

    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    private void OnGUI()
    {
        var centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;
        GUI.Label(new Rect(Screen.width / 5 , Screen.height / 2 , 500, 50),"Player state = " + m_currentState.ToString(), centeredStyle);
  
    }

}
