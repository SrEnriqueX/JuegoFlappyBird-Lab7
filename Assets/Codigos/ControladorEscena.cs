using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public GameObject canvasPerdiste;
    private LogicaMenuPausa logicaMenuPausa;

    void Start()
    {
        Time.timeScale = 1;
        logicaMenuPausa = FindObjectOfType<LogicaMenuPausa>();

    }


    void Update()
    {
        
    }

    public void Perdiste()
    {
        canvasPerdiste.SetActive(true);
        Time.timeScale = 0;

        if (logicaMenuPausa != null)
        {
            logicaMenuPausa.OcultarBotonPausa();
        }
    }
    public void Reiniciar()
    {

        if (logicaMenuPausa != null)
        {
            logicaMenuPausa.Reiniciar();
        }

    }
}
