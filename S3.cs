using UnityEngine;

public class Situacion3 : MonoBehaviour
{
    public GameObject plano;
    public GameObject cubo;
    public GameObject esfera;

    void Start()
    {
        // Configuración del Plano (sin Rigidbody)
        if (plano.GetComponent<Rigidbody>() != null)
        {
            Destroy(plano.GetComponent<Rigidbody>());
        }

        // Configuración del Cubo (con Rigidbody)
        if (cubo.GetComponent<Rigidbody>() == null)
        {
            cubo.AddComponent<Rigidbody>();
        }

        // Configuración de la Esfera (Cinemática)
        Rigidbody rbEsfera = esfera.GetComponent<Rigidbody>();
        if (rbEsfera == null)
        {
            rbEsfera = esfera.AddComponent<Rigidbody>();  // Añadir si no existe
        }
        rbEsfera.isKinematic = true;  // Esfera cinemática
    }
}
