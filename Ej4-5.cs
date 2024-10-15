using UnityEngine;

public class MovimientoCuboEsfera : MonoBehaviour
{
    // Velocidad de movimiento, modificable en el Inspector
    public float speed = 5.0f;

    // Identificación del objeto: esCubo o esEsfera
    public bool esCubo = false;
    public bool esEsfera = false;

    // Update es llamado una vez por frame
    void Update()
    {
        if (esCubo)
        {
            // Movimiento del cubo con las teclas de flecha (arriba-abajo, izquierda-derecha)
            float horizontalCubo = 0f;
            float verticalCubo = 0f;

            if (Input.GetKey(KeyCode.LeftArrow)) horizontalCubo = -1;  
            if (Input.GetKey(KeyCode.RightArrow)) horizontalCubo = 1;  
            if (Input.GetKey(KeyCode.UpArrow)) verticalCubo = 1;  
            if (Input.GetKey(KeyCode.DownArrow)) verticalCubo = -1;  

            // Trasladar el cubo según la velocidad y los ejes
            transform.Translate(new Vector3(horizontalCubo, 0, verticalCubo) * speed * Time.deltaTime);
        }
        
        if (esEsfera)
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
