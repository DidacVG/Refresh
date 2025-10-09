using UnityEngine;

public class DestruccionTargets : MonoBehaviour
{
    public Transform Target;
    public Transform TargetBroken;

    private Renderer TargetRender;
    private Collider TargetCollider;

    private float contadorTarget = 0f;
    private bool targetRoto;

    public Puntuacion puntuacionScript;

    public int sumarPuntos = 100;
    void Start()
    {
        TargetRender = GetComponent<Renderer>();
        TargetCollider = GetComponent<Collider>();
    }

    private void Update()
    {
        if (targetRoto)
        {
            contadorTarget -= Time.deltaTime;

            if (contadorTarget <= 0f)
            {
                // Reactivar el target
                if (TargetRender != null) TargetRender.enabled = true;
                if (TargetCollider != null) TargetCollider.enabled = true;

                targetRoto = false; // vuelve al estado normal
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == null) return;

        if (other.gameObject.CompareTag("Bala"))
        {
            if (TargetRender != null) TargetRender.enabled = false;
            if (TargetCollider != null) TargetCollider.enabled = false;

            if (TargetBroken != null && Target != null)
            {
                Instantiate(TargetBroken, Target.position, TargetBroken.rotation);
            }

            targetRoto = true;
            contadorTarget = 3f;

            puntuacionScript.puntuacion += sumarPuntos;
        }
    }
}