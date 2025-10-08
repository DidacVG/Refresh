using UnityEngine;
using UnityEngine.InputSystem;

public class Camara : MonoBehaviour
{
    public Transform pivot;
    public float rotacionX = 0f;
    public float rotacionY = 0f;

    InputManager input;

    void Start()
    {
        input = new InputManager();
        input.Enable();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Leer la entrada de movimiento (WASD)
        Vector2 move = input.Player.Move.ReadValue<Vector2>(); // x = A/D, y = W/S

        // Calcular cuánto rotar basado en la entrada y el tiempo
        float yaw = -move.x * rotacionX * Time.deltaTime;   // izquierda/derecha
        float pitch = move.y * rotacionY * Time.deltaTime; // arriba/abajo (negativo para invertir control vertical)

        Vector3 currentEuler = pivot.localEulerAngles;

        // Ajustar pitch para que esté entre -90 y 90 grados para evitar giro invertido
        float pitchAngle = currentEuler.x + pitch;
        if (pitchAngle > 180) pitchAngle -= 360; // Normalizar ángulo
        pitchAngle = Mathf.Clamp(pitchAngle, -90f, 90f);

        pivot.localEulerAngles = new Vector3(pitchAngle, currentEuler.y + yaw, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
