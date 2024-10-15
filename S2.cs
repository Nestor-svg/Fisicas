using UnityEngine;

public class Situacion2 : MonoBehaviour
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

        // Configuración de la Esfera (con Rigidbody)
        if (esfera.GetComponent<Rigidbody>() == null)
        {
            esfera.AddComponent<Rigidbody>();  // Añadir Rigidbody si no tiene
        }
    }
}
