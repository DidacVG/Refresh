using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public TMP_Text puntuacionTexto;
    public int puntuacion = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (puntuacionTexto != null)
        {
            puntuacionTexto.text = puntuacion.ToString();
        }
    }
}
