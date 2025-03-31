using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumaYProducto : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    int resultado;

    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log("El resultado de la suma es: " + resultado);
        resultado = num1 * num2;
        Debug.Log("El resultado de la multiplicacion es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
