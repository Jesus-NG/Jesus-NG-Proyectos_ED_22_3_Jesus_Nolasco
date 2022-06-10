using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    //TextMesh es una cadena de texto. Este componente sirve para mostar un teto en la escena. 
    public TextMeshProUGUI texto;

    //Es una variable publica, en donde acelerador actua como un dato numerico.
    public int acelerador;

    //Actua como una secuencia de caracteres, y al igual que "acelerador", es una variable publica.
    public string freno;
    
    // Start is called before the first frame update
    void Start()
    {
        //Es una instruccion que indica la accion que se debe realizar.
        texto.text = "Acelera";
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey sirve para declarar una entrada de informacion sostenida, mietras que if son las instrucciones que debe de seguir el codigo.
        if(Input.GetKey(KeyCode.R))
        {
            //Esta orden sirve para aumentar la cantidad de numeros en uno por el momento en el que se deje presionada la tecla, llamando a la variable acelerador.
            acelerador++;
            //If anidado que entra en accion para que el siguiente tenga un funcionamiento.
            {
                
                //Esta cantidad determinara el numero al que puede llegar nuestro programa (No podra pasar de ese numero).
                acelerador = 200;
                //Valor numerico se lee como cadena de texto, agreganto un punto seguido del comando ToString
                texto.text = acelerador.ToString();
            }

        }
         //Funciona mientras se deje presionada la tecla y cuando se libere de la accion
        if(Input.GetKey(KeyCode.R))
            {
                //Variable tipo cadena de texto denominada freno.
                texto.text = freno;
            }
        //texto.text = acelerador.ToString();
    }
}//FIN DEL PROGRAMA
