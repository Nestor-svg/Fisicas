using UnityEngine;

public class Ej10 : MonoBehaviour
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
        rbPlano.isKinematic = true;  // El plano será cinemático para no ser afectado por la física

        // Configuración del Cubo (cinemático)
        Rigidbody rbCubo = cubo.GetComponent<Rigidbody>();
        if (rbCubo == null)
        {
            rbCubo = cubo.AddComponent<Rigidbody>();
        }
        rbCubo.isKinematic = true;  // El cubo es cinemático

        // Configuración de la Esfera 
        Rigidbody rbEsfera = esfera.GetComponent<Rigidbody>();
        if (rbEsfera == null)
        {
            rbEsfera = esfera.AddComponent<Rigidbody>();
        }
        rbEsfera.isKinematic = false;  // La esfera es un objeto físico, no cinemático
    }
}
