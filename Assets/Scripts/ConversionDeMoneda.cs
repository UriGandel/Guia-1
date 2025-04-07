using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public char monedaAConvertir;
    public float monto;
    float resultado;

    float cotizacionDolar = 1621.3f;
    float cotizacionEuro = 1297.21f;
    float cotizacionReal = 183.0f;


    // Start is called before the first frame update
    void Start()
    {
        if (monto < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }
        else
        {
            if (monedaAConvertir == 'D')
            {
                resultado /= cotizacionDolar;
            }
            else if (monedaAConvertir == 'E')
            {
                resultado /=  cotizacionEuro;
            }
            else if (monedaAConvertir == 'R')
            {
                resultado /= cotizacionReal;
            }
            else
            {
                Debug.Log("Opción de moneda extranjera no válida");
                return;
            }
            Debug.Log("El resultado de la conversion es: " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
