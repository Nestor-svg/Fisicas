using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    // Campo de velocidad que será editable en el Inspector
    public float velocidad = 5.0f;

    // Update es llamado una vez por frame
    void Update()
    {
        // Obtenemos los valores de los ejes horizontales y verticales
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Detectamos si se ha pulsado alguna de las teclas de las flechas
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha Arriba: " + (vertical * velocidad));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha Abajo: " + (vertical * velocidad));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha Izquierda: " + (horizontal * velocidad));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha Derecha: " + (horizontal * velocidad));
        }

        // Detectar si la tecla de disparo (H) ha sido presionada
        if (Input.GetButtonDown("Disparo"))  // Usamos el nombre del Input Manager
        {
            Debug.Log("¡Disparo realizado!");
        }
    }
}
