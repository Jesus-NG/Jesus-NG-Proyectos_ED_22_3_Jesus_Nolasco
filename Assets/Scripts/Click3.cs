using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click3 : MonoBehaviour
{    
    public string mensaje;
    Color clkColor = Color.blue;
 
    public bool _clicked;
 
 
    void Start()
    {
        _clicked = false;
    }
 
 
    void OnMouseDown()
    {
        _clicked = true;
        this.GetComponent<SpriteRenderer>().color = clkColor;

        Debug.Log(mensaje);

    }
    public void OnMouseEnter()
    {
        if (_clicked == true)
        {
            this.GetComponent<SpriteRenderer>().color = clkColor;
        }
 
    }

}
