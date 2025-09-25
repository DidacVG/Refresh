using UnityEngine;
using UnityEngine.InputSystem;

public class ControlesTorreta : MonoBehaviour
{
    public Transform baseTorreta;
    public Transform pivoteca�on;

    public float velocidadRotacion = 100f;
    public float limiterotacionTorreta = 90f;
    public float limiterotacion = 90f;

    private float rotacionY = 0f;
    private float rotacionX = 0f;

    private GameObject ca�on;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        ca�on = new GameObject("Ca�on");
        ca�on.transform.position = transform.position;
        ca�on.transform.rotation = transform.rotation;
        transform.SetParent(ca�on.transform, true);

        rotacionY = baseTorreta.localEulerAngles.y;
        rotacionX = pivoteca�on.localEulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();

        float mouseX = mouseDelta.x * velocidadRotacion * Time.deltaTime;
        float mouseY = mouseDelta.y * velocidadRotacion * Time.deltaTime;

        rotacionY += mouseX;
        baseTorreta.localEulerAngles = new Vector3(0f, rotacionY, 0f);
        rotacionY = Mathf.Clamp(rotacionY, -limiterotacionTorreta, limiterotacionTorreta);

        rotacionX -= mouseY;
        rotacionX = Mathf.Clamp(rotacionX, -limiterotacion, limiterotacion);

        pivoteca�on.localEulerAngles = new Vector3(rotacionX, baseTorreta.eulerAngles.y, 0f);
    }
    public void ResetearPosicionLocal()
    {
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
}