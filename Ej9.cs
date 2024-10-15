using UnityEngine;

public class DeteccionColisiones : MonoBehaviour
{
    // Este método se llama cuando otro objeto con un Collider
    // colisiona con el objeto que tiene este script.
    void OnCollisionEnter(Collision collision)
    {
        // Mostrar el nombre del objeto con el que hemos colisionado en la consola
        Debug.Log("Colisión con: " + collision.gameObject.tag);
    }
}
