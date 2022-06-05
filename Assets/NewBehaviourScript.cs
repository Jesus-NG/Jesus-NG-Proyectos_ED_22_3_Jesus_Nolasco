using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            texto.text = "Bienvenido Jefe Maestro.";
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            texto.text = "Los dioses del olimpo me han abandonado.";
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            texto.text = "Luke, Yo soy tu padre.";
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            texto.text = "Que detalle.";
        }
    }
}//FIN DEL PROGRAMA
