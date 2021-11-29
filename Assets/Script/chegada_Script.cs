using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chegada_Script : MonoBehaviour
{
    [SerializeField] private Controlador_Script controlador;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bola"))
        {
            Destroy(other.gameObject);
            controlador.Set_Chegada();
        }
    }
}
