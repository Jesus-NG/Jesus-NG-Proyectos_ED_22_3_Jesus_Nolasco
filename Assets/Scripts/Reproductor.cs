using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{
[SerializeField]
    AudioSource audioS;
    public AudioClip[] ListaAudio;
    public int indice = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        //ListaAudio = new AudioClip[3];

        audioS.clip = ListaAudio[indice];

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
              indice++; 
              if (indice >= ListaAudio.Length)
              {
                Debug.Log("Has llegado a la meta");
                indice = ListaAudio.Length-1;
              }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
              indice--; 
              if (indice <= 0)
              {
                Debug.Log("Has regresado");
                indice = 0;
              }
        }

        audioS.clip = ListaAudio[indice];
    }
}
