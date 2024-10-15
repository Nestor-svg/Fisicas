using UnityEngine;

public class Situacion6 : MonoBehaviour
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
            rbPlano = plano.AddComponent<Rigidbody>();
        }
        rbPlano.isKinematic = true;

        // Configuración del Cubo (con Rigidbody)
        Rigidbody rbCubo = cubo.GetComponent<Rigidbody>();
        if (rbCubo == null)
        {
            rbCubo = cubo.AddComponent<Rigidbody>();
        }

        // Configuración de la Esfera (con masa 100 veces mayor)
        Rigidbody rbEsfera = esfera.GetComponent<Rigidbody>();
        if (rbEsfera == null)
        {
            rbEsfera = esfera.AddComponent<Rigidbody>();
        }
        rbEsfera.mass = rbCubo.mass * 100;  // Masa 100 veces mayor
    }
}
