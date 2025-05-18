using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public GameObject canvasPerdiste;

    void Start()
    {
        Time.timeScale = 1;
    }


    void Update()
    {
        
    }

    public void Perdiste()
    {
        canvasPerdiste.SetActive(true);
        Time.timeScale = 0;
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
