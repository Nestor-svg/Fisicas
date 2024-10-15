using UnityEngine;

public class Situacion1 : MonoBehaviour
{
    public GameObject plano;
    public GameObject cubo;
    public GameObject esfera;

    void Start()
    {
        // Configuración del Plano (sin Rigidbody)
        if (plano.GetComponent<Rigidbody>() != null)
        {
            Destroy(plano.GetComponent<Rigidbody>());  // Eliminar Rigidbody si existe
        }

        // Configuración del Cubo (con Rigidbody)
        if (cubo.GetComponent<Rigidbody>() == null)
        {
            cubo.AddComponent<Rigidbody>();  // Añadir Rigidbody si no tiene
        }

        // Configuración de la Esfera (sin Rigidbody)
        if (esfera.GetComponent<Rigidbody>() != null)
        {
            Destroy(esfera.GetComponent<Rigidbody>());  // Eliminar Rigidbody si existe
        }
    }
}
