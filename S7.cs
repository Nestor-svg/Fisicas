using UnityEngine;

public class Situacion7 : MonoBehaviour
{
    public GameObject plano;
    public GameObject cubo;
    public GameObject esfera;
    public PhysicMaterial friccionMaterial; // El material de fricción

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

        // Configuración de la Esfera (con fricción y Rigidbody)
        Rigidbody rbEsfera = esfera.GetComponent<Rigidbody>();
        if (rbEsfera == null)
        {
            rbEsfera = esfera.AddComponent<Rigidbody>();
        }
        SphereCollider esferaCollider = esfera.GetComponent<SphereCollider>();
        if (esferaCollider != null && friccionMaterial != null)
        {
            esferaCollider.material = friccionMaterial;  // Asignamos el material de fricción
        }
    }
}
