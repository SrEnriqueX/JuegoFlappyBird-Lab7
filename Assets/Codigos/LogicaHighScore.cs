using UnityEngine;
using TMPro;

public class LogicaHighScore : MonoBehaviour
{
    public TextMeshProUGUI textoHighScore;

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0); // Si no existe, devuelve 0.
        textoHighScore.text = highScore.ToString();
        ActualizarTextoHighScore();
    }
    // Método para resetear el High Score a 0.
    public void ResetearHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore"); // Elimina la clave guardada.
        PlayerPrefs.Save(); // Guarda los cambios.
        ActualizarTextoHighScore(); // Actualiza el texto en pantalla.
    }
    // Actualiza el texto del High Score.
    private void ActualizarTextoHighScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        textoHighScore.text = highScore.ToString();
    }
    public static void ActualizarHighScore(int puntaje)
    {
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (puntaje > currentHighScore)
        {
            PlayerPrefs.SetInt("HighScore", puntaje);
            PlayerPrefs.Save(); // Guarda inmediatamente.
        }
    }
}
