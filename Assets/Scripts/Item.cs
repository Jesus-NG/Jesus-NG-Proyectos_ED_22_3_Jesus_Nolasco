using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="Nuevo Item")]

public class Item : ScriptableObject
{
public string nombre;
public string tipo;
public string precio;
public string efecto;
public string[] datos;

    // Start is called before the first frame update
    void OnEnable()
    {
        datos = new string[]{nombre, tipo, precio, efecto};
    }

   public string GetDatos(int indice){
    return datos[indice];
   }
}
