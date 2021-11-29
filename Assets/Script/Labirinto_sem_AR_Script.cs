using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirinto_sem_AR_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * 180 * Time.deltaTime);
        }
    }
}
