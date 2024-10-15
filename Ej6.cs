using UnityEngine;

public class MovimientoCuboEsfera2 : MonoBehaviour
{
    // Velocidad de movimiento, modificable en el Inspector
    public float speed = 5.0f;

    // Referencia a la esfera
    public Transform esfera;  // Referencia al objeto de la esfera

    // Update es llamado una vez por frame
    void Update()
    {
        // Verificamos si la referencia a la esfera está asignada
        if (esfera != null)
        {
            // Calculamos el vector de dirección desde el cubo hacia la esfera
            Vector3 direccion = esfera.position - transform.position;

            // Aseguramos que el cubo se mueva solo en el plano XZ
            direccion.y = 0; // Ignoramos la altura (componente Y)

            // Normalizamos el vector para que el cubo se mueva a una velocidad constante
            direccion = direccion.normalized;

            // Movemos el cubo hacia la posición de la esfera
            transform.Translate(direccion * speed * Time.deltaTime);
        }
    }
}
