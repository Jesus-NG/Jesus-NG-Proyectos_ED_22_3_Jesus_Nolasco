using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{
[SerializeField]
    AudioSource audioS; //Hace una referencia al componente que quiero manipular.
    public AudioClip[] ListaAudio; //Crea un arreglo de clipsde audio.
    public int indice = 0; //Un valor mutable para recorrer el arreglo.

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>(); //Enlaza o lee el componente AudioSource en el objeto.
        //Propietario de este script.
        //ListaAudio = new AudioClip[3];

        audioS.clip = ListaAudio[indice]; //Asigna desde la lista el valor inicial que debe reproucir el audiosource.
        audioS.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Asigno una tecla.
        {
          AumentarIndice();
        }

        if (Input.GetKeyDown(KeyCode.B)) //Asigno una tecla.
        {
          DisminuirIndice();
        }

        audioS.clip = ListaAudio[indice]; //Actualiza el valor del cli asignado a el AudioSource.
        audioS.Play();
    }//Fin update

    //Aqui inician los metodos o funciones
    public void AumentarIndice()
    {
      indice++; //Aumento el indice.
              if (indice >= ListaAudio.Length) //Comparo el valor el indice con la cantidad de elementos.
              {
                Debug.Log("Has llegado a la meta");
                indice = ListaAudio.Length-1; //Asigno a indice el ultimo valor conocido de la lista.
              }
    }

    public void DisminuirIndice()
    {
      indice--; //Disminuyo el indicce
              if (indice <= 0) //Comparo el valor de indice con la cantidad de elementos.
              {
                Debug.Log("Has regresado");
                indice = 0; //Asigno a indice el ultimo valor coocido en la lista.
              }
    }
}//Fin de clase
