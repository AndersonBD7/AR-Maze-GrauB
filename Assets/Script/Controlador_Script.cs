using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Script : MonoBehaviour
{
    [SerializeField] private GameObject[] Labirintos = new GameObject[4];
    [SerializeField] private GameObject bola;
    [SerializeField] private Transform[] Ponto_Inicial = new Transform[4];
    [SerializeField] private GameObject[] Chegada = new GameObject[4];
    [SerializeField] private GameObject[] Ok_obj = new GameObject[4];
    [SerializeField] private bool[] Labirintos_concluidos = new bool[4];
    GameObject[] bolas;
    int cont_maze = 0;
    // Start is called before the first frame update
    void Start()
    {
        Reset_Game();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reset_Game()
    {
        if (cont_maze < 4)
        {
            bolas = GameObject.FindGameObjectsWithTag("Bola");
            for (int i = 0; i < bolas.Length; i++)
            {
                Destroy(bolas[i]);
            }
            for (int i = 0; i < 4; i++)
            {
                Ok_obj[i].SetActive(false);
                Chegada[i].SetActive(true);
                Labirintos_concluidos[i] = false;
                cont_maze = 0;
            }
            Instantiate(bola, Ponto_Inicial[cont_maze].position, Ponto_Inicial[cont_maze].rotation, Labirintos[cont_maze].transform);
        }
    }
    public void Set_Chegada()
    {
        Ok_obj[cont_maze].SetActive(true);
        Chegada[cont_maze].SetActive(false);
        Labirintos_concluidos[cont_maze] = true;
        cont_maze++;
        Instantiate(bola, Ponto_Inicial[cont_maze].position, Ponto_Inicial[cont_maze].rotation, Labirintos[cont_maze].transform);
    }
}
