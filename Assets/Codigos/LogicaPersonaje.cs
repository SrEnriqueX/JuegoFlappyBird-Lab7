using System.Net.NetworkInformation;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocidad = 1;
    private Rigidbody2D rb;

    public ControladorEscena controladorEscena;

    public AudioSource audioVolar;

    public AudioSource audioGolpe;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            /*rb.linearVelocity = Vector2.up * velocidad;
            audioVolar.Play();*/
            // Verifica si el juego est� activo (timeScale = 1 y canvasPerdiste desactivado).
            if (Time.timeScale == 1 && !controladorEscena.canvasPerdiste.activeSelf)
            {
                rb.linearVelocity = Vector2.up * velocidad;
                audioVolar.Play();
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //controladorEscena.Perdiste();
        if (collision.gameObject.CompareTag("Obstaculo") || collision.gameObject.CompareTag("Suelo"))
        {
            controladorEscena.Perdiste();
            audioGolpe.Play(); // Sonido único para todos.

            // Opcional: Diferenciar efectos (ej: sonido distinto para suelo).
            // if (collision.gameObject.CompareTag("Suelo")) audioSuelo.Play();
        }
    }
}
