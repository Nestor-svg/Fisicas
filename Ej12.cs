using UnityEngine;

public class MovimientoCilindro : MonoBehaviour
{
    // Variables para la velocidad y la rotación
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f;

    // Referencia al objetivo (la esfera)
    public Transform goal;

    // Referencia al Rigidbody del cilindro
    private Rigidbody rb;

    void Start()
    {
        // Intentamos obtener el componente Rigidbody
        rb = GetComponent<Rigidbody>();

        // Si no tiene un Rigidbody, se lo añadimos
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }

        // Asegúrate de que el cilindro no esté en modo cinemático
        rb.isKinematic = false;
    }

    void Update()
    {
        // Obtenemos la entrada del jugador (WASD o teclas de dirección)
        float moveX = Input.GetAxis("Horizontal"); // A-D o flechas izquierda-derecha
        float moveZ = Input.GetAxis("Vertical");   // W-S o flechas arriba-abajo

        // Movimiento del cilindro en función de la entrada del jugador
        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;

        // Mover el cilindro usando el Rigidbody (para respetar las físicas)
        rb.MovePosition(transform.position + movement);

        // Girar hacia la esfera
        if (goal != null)
        {
            // Crear un vector que apunte hacia la esfera sin modificar la altura del cilindro
            Vector3 lookAtGoal = new Vector3(goal.position.x, transform.position.y, goal.position.z);
            transform.LookAt(lookAtGoal);  // Hace que el cilindro gire para mirar a la esfera

            // Rotación gradual hacia la esfera
            Vector3 direction = (goal.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
