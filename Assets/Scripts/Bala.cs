using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.InputSystem;

public class Bala : MonoBehaviour
{

    public float bulletSpeed = 10;
    public Rigidbody bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.linearVelocity = transform.forward * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetButtonDown("Fire1"))
            Fire();
    }

    void Gravedad()
    {
        Physics.gravity = new Vector3(0, -1.0F, 0);
    }
}
