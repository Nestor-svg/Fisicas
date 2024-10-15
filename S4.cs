using UnityEngine;

public class Situacion4 : MonoBehaviour
{
    public GameObject plano;
    public GameObject cubo;
    public GameObject esfera;

    void Start()
    {
        // Configuración del Plano (con Rigidbody y cinemático)
        Rigidbody rbPlano = plano.GetComponent<Rigidbody>();
        if (rbPlano == null)
        {
            rbPlano = plano.AddComponent<Rigidbody>();  // Añadir si no tiene
        }
        rbPlano.isKinematic = true;  // El plano no se moverá

        // Configuración del Cubo (con Rigidbody)
        if (cubo.GetComponent<Rigidbody>() == null)
        {
            cubo.AddComponent<Rigidbody>();
        }

        // Configuración de la Esfera (con Rigidbody)
        if (esfera.GetComponent<Rigidbody>() == null)
        {
            esfera.AddComponent<Rigidbody>();
        }
    }
}
