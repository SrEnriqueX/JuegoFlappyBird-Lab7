using UnityEngine;

public class LogicaObstaculo : MonoBehaviour
{
    public float velocidad;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
    }
}
