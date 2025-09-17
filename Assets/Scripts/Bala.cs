using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.InputSystem;

public class Bala : MonoBehaviour
{

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gravedad()
    {
        Physics.gravity = new Vector3(0, -1.0F, 0);
    }
}
