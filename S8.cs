using UnityEngine;

public class Situacion8 : MonoBehaviour
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

        // Configuración de la Esfera (como Trigger sin Rigidbody)
        Collider esferaCollider = esfera.GetComponent<Collider>();
        if (esferaCollider != null)
        {
            esferaCollider.isTrigger = true;  // La esfera es un Trigger
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Un objeto ha entrado en el Trigger de la esfera: " + other.gameObject.name);
    }
}
