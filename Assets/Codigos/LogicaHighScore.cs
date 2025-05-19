using UnityEngine;
using TMPro;

public class LogicaHighScore : MonoBehaviour
{
    public TextMeshProUGUI textoHighScore;

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0); // Si no existe, devuelve 0.
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
