using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour
{
    public string codigo;

    const int cantidadGatos = 300;
    const int cantidadPerrosChicos = 400;
    const int cantidadPerrosGrandes = 700;
    float costo;
    // Start is called before the first frame update
    void Start()
    {
        if(codigo == "G")
        {
            Debug.Log("Para ese periodo se necesitan " + cantidadGatos + "gramos");
            costo = (cantidadGatos / 100) * 80;
        }
        if (codigo == "P")
        {
            Debug.Log("Para ese periodo se necesitan " + cantidadPerrosChicos + "gramos");
            costo = (cantidadPerrosChicos / 100) * 80;

        }
        if (codigo == "PG")
        {
            Debug.Log("Para ese periodo se necesitan " + cantidadPerrosGrandes + "gramos");
            costo = (cantidadPerrosGrandes / 100) * 80;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
