using UnityEngine;

public class RestarPuntos : MonoBehaviour
{
    public Puntuacion puntuacionScript;
    public int restarPuntos = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            puntuacionScript.puntuacion -= restarPuntos;
        }
    }
}
