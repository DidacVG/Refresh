using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Target : MonoBehaviour
{
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
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            Destroy(gameObject);
        }
    }
}
