using UnityEngine;

public class Situacion9 : MonoBehaviour
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
        rbPlano.isKinematic = true;  // El plano es estático

        // Configuración del Cubo (con Rigidbody)
        Rigidbody rbCubo = cubo.GetComponent<Rigidbody>();
        if (rbCubo == null)
        {
            rbCubo = cubo.AddComponent<Rigidbody>();
        }

        // Configuración de la Esfera (como Trigger con Rigidbody)
        Rigidbody rbEsfera = esfera.GetComponent<Rigidbody>();
        if (rbEsfera == null)
        {
            rbEsfera = esfera.AddComponent<Rigidbody>();
        }

        Collider esferaCollider = esfera.GetComponent<Collider>();
        if (esferaCollider != null)
        {
            esferaCollider.isTrigger = true;  // La esfera es un Trigger
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Un objeto ha entrado en el Trigger de la esfera (con físicas): " + other.gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Un objeto ha salido del Trigger de la esfera (con físicas): " + other.gameObject.name);
    }
}
