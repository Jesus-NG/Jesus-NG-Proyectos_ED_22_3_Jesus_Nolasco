using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI[] datosText;
    public Item objDatos;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < datosText.Length; i++)
        {
            datosText[i].text = objDatos.GetDatos(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
