using UnityEngine;
using UnityEngine.InputSystem;

public class ControlesTorreta : MonoBehaviour
{
    private float Horizontal = 0;
    private float Vertical = 0;
    InputManager input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 rotation = transform.localEulerAngles;
        Vertical = rotation.y;
        Horizontal = rotation.x;
        Cursor.lockState = CursorLockMode.Locked;
        input = new InputManager();
        input.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = input.Player.Move.ReadValue<Vector2>();
    }
}
