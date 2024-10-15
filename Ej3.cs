using UnityEngine;

public class MovimientoProporcional : MonoBehaviour
{
    // El vector que indica la dirección del movimiento, editable en el Inspector
    public Vector3 moveDirection = new Vector3(1, 0, 0);  // Vector por defecto (hacia la derecha)
    
    // La velocidad a la que se mueve el cubo, editable en el Inspector
    public float speed = 2.0f;  // Velocidad inicial mayor que 1

    // Update es llamado una vez por frame
    void Update()
    {
        // Trasladar el cubo en cada frame, basado en la dirección y la velocidad
        transform.Translate(moveDirection * speed * Time.deltaTime);

        // Movimiento en el espacio local (relativo a la orientación del cubo)
        // transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
    }
}
