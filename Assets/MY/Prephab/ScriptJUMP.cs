using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJUMP : MonoBehaviour
{
    void JUMP(IA didier1,Player didier2)
    {
        didier1.transform.position += Vector3.up * 1000f * Time.deltaTime;
    }
}
