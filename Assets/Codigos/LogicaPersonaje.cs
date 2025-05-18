using System.Net.NetworkInformation;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocidad = 1;
    private Rigidbody2D rb;

    public ControladorEscena controladorEscena;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            rb.linearVelocity = Vector2.up * velocidad;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controladorEscena.Perdiste();
    }
}
