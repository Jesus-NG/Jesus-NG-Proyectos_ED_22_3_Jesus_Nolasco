using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public string mensaje;

    void OnMouseDown() 
    {
    //Destruir el GameObject despues de darle click
    Destroy(gameObject);
    //Crear mensaje despues de darle click
    Debug.Log(mensaje);
    }
    
}
