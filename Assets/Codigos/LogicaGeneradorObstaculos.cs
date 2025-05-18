using UnityEngine;

public class LogicaGeneradorObstaculos : MonoBehaviour
{
    public float tiempoMax = 1;
    private float tiempoInicial = 0;
    public GameObject obstaculo;
    public float altura;
    
    void Start()
    {
        GameObject obstaculoNuevo=Instantiate(obstaculo);
        obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(obstaculoNuevo, 8);
    }

    void Update()
    {
       if(tiempoInicial > tiempoMax)
        {
            GameObject obstaculoNuevo = Instantiate(obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-altura,altura), 0);
            Destroy(obstaculoNuevo, 8);
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
    }
}
