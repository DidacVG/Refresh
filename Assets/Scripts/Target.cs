using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] puntosMovimiento;

    [SerializeField] private float velocidadMovimiento;

    private int siguientePunto = 1;

    private bool ordenPunto = true;
    private Rigidbody Rigidbody;
    public float Velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(Velocidad , 0, 0) * Time.deltaTime;

        if (gameObject.tag == "Target_Rojo")
        {
            if (ordenPunto && siguientePunto + 1 >= puntosMovimiento.Length)
            {
                ordenPunto = false;
            }

            if (!ordenPunto && siguientePunto <= 0)
            {
                ordenPunto = true;
            }

            if (Vector3.Distance(transform.position, puntosMovimiento[siguientePunto].position) < 0.1f)
            {
                if (ordenPunto)
                {
                    siguientePunto += 1;
                }
                else
                {
                    siguientePunto -= 1;
                }
            }

            transform.position = Vector3.MoveTowards(transform.position, puntosMovimiento[siguientePunto].position, velocidadMovimiento * Time.deltaTime);
        }
    }
}
