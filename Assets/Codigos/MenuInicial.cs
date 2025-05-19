using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuInicial : MonoBehaviour
{
    public void IniciarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
