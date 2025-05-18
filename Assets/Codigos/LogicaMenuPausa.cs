using UnityEngine;
using UnityEngine.SceneManagement;
public class LogicaMenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Pausa()
    {
        Time.timeScale =0;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reanudar()
    {
        Time.timeScale = 1;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar() { 
        Time.timeScale = 1;
        LogicaPuntaje.puntaje = 0;  // Resetear puntaje.
        // Reactivar personaje original y desactivar el nuevo.
        FindObjectOfType<LogicaPuntaje>().personajeOriginal.SetActive(true);
        FindObjectOfType<LogicaPuntaje>().personajeNuevo.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OcultarBotonPausa()
    {
        botonPausa.SetActive(false);
        menuPausa.SetActive(false);  
    }
}
