using UnityEngine;

public class MovimientoCuboEsfera3 : MonoBehaviour
{
    // Velocidad de movimiento, modificable en el Inspector
    public float speed = 5.0f;

    // Referencia a la esfera
    public Transform esfera;  // Referencia al objeto de la esfera
    public bool esEsfera1 = false;

    // Update es llamado una vez por frame
    void Update()
    {
        // Verificamos si la referencia a la esfera está asignada
        if (esfera != null)
        {
            // Calculamos el vector de dirección desde el cubo hacia la esfera
            Vector3 direccion = esfera.position - transform.position;

            // Aseguramos que el cubo se mueva solo en el plano XZ (sin altura)
            direccion.y = 0; // Ignoramos la altura (componente Y)

            // Rotamos el cubo hacia la esfera
            transform.LookAt(esfera);

            // Movemos el cubo en la dirección de la esfera, normalizando el vector de dirección
            direccion = direccion.normalized;

            // Movemos el cubo hacia la esfera, solo en el plano horizontal
            transform.Translate(direccion * speed * Time.deltaTime);
        }
        if (esEsfera1)
        {
            // Movimiento de la esfera con las teclas W-S (vertical) y A-D (horizontal)
            float horizontalEsfera = 0f;
            float verticalEsfera = 0f;

            // Detectamos las teclas WASD
            if (Input.GetKey(KeyCode.A)) horizontalEsfera = -1;
            if (Input.GetKey(KeyCode.D)) horizontalEsfera = 1;
            if (Input.GetKey(KeyCode.W)) verticalEsfera = 1;
            if (Input.GetKey(KeyCode.S)) verticalEsfera = -1;

            // Trasladar la esfera según la velocidad y los ejes
            transform.Translate(new Vector3(horizontalEsfera, 0, verticalEsfera) * speed * Time.deltaTime);
        }
    }
}
