using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeQueOrientacionSos : MonoBehaviour
{
    public string nombreDelAlumno;
    public int añoQueCursa;
    public char orientacionALaQuePertenece;
    // Start is called before the first frame update
    void Start()
    {
        if(nombreDelAlumno == "" || añoQueCursa > 5 || añoQueCursa < 1)
        {
            Debug.Log("El nombre y / o el año no son validos");
        }
        else if(orientacionALaQuePertenece != 'T'|| orientacionALaQuePertenece != 'M' || orientacionALaQuePertenece != 'G' || orientacionALaQuePertenece != 'H' || orientacionALaQuePertenece != 'D')
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
        else if(añoQueCursa < 3){
            Debug.Log("Error. Aún estás en el ciclo básico");
        }
        else
        {
            Debug.Log("Muchas gracias " + nombreDelAlumno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
