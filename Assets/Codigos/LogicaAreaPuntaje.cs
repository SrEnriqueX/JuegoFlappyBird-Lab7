using UnityEngine;

public class LogicaAreaPuntaje : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LogicaPuntaje.puntaje++;
    }
}
