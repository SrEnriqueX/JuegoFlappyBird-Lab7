using System.Net.NetworkInformation;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocidad = 1;
    private Rigidbody2D rb;

    public ControladorEscena controladorEscena;

    public AudioSource audioVolar;

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
        controladorEscena.Perdiste();
    }
}
