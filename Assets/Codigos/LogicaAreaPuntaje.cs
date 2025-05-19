using UnityEngine;

public class LogicaAreaPuntaje : MonoBehaviour
{
    public AudioSource audioPuntaje;

    void Start()
    {
        
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //LogicaPuntaje.puntaje++;

        if (collision.CompareTag("Player")) 
        {
            LogicaPuntaje.puntaje++;
            audioPuntaje.Play(); 
        }
    }
}
