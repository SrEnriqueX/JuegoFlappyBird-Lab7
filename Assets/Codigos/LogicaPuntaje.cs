using UnityEngine;
using TMPro;
public class LogicaPuntaje : MonoBehaviour
{
    public static int puntaje = 0;

    public GameObject personajeOriginal;  
    public GameObject personajeNuevo;    


    void Start()
    {
        puntaje = 0;
        personajeNuevo.SetActive(false); 
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = puntaje.ToString();
        
        if (puntaje >= 3 && personajeOriginal.activeSelf)
        {
            CambiarPersonaje();
        }
    }
    void CambiarPersonaje()
    {
        // Copiar posición y rotación del personaje original al nuevo.
        personajeNuevo.transform.position = personajeOriginal.transform.position;
        personajeNuevo.transform.rotation = personajeOriginal.transform.rotation;

        // Copiar la velocidad del Rigidbody2D para mantener el movimiento.
        Rigidbody2D rbOriginal = personajeOriginal.GetComponent<Rigidbody2D>();
        Rigidbody2D rbNuevo = personajeNuevo.GetComponent<Rigidbody2D>();
        rbNuevo.linearVelocity = rbOriginal.linearVelocity;

        personajeOriginal.SetActive(false);
        personajeNuevo.SetActive(true);
    }
}
