using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Laura Gonzalez Sandoval
//Jesús Horacio Nolasco Gallegos

// fuentes: dosc.unity3d.com/ScriptRefence/Vector3.html

public class Move : MonoBehaviour
{
    //Asignamos un button a un GameObject
    [SerializeField] private GameObject button;
    private void Update()
    {
        //Aquí asiganmos un botón para nuestro sprite
        //Este if aplica para los demás, lo único que cambia es la tecla asignada y la dirección del vector
        if(Input.GetKeyDown(KeyCode.D))
        {
            //Aquí asiganmos la dirección de nuestro sprite hacia el vector designado
            transform.position += new Vector3 (5,0,0);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3 (-5,0,0);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3 (0,5,0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3 (0,-5,0);
        }
    }
}
