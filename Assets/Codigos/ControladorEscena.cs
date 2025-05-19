using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public GameObject canvasPerdiste;
    private LogicaMenuPausa logicaMenuPausa;
    public TextMeshProUGUI textoHighScoreMuerte;

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
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        textoHighScoreMuerte.text = highScore.ToString(); // Mostrar récord.

        LogicaHighScore.ActualizarHighScore(LogicaPuntaje.puntaje); // Guarda el récord.
        if (logicaMenuPausa != null)
        {
            logicaMenuPausa.OcultarBotonPausa();
        }
    }
    public void Reiniciar()
    {
        if (logicaMenuPausa != null){logicaMenuPausa.Reiniciar();}
    }
}
