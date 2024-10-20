using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Reiniciar()
    {
        CharacterVidaMana.vida = 3;
        Coin.monedas = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Carga la misma escena
    }

    public void MenuInicial(string nombre)
    {
        CharacterVidaMana.vida = 3;
        Coin.monedas = 0;
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        //UnityEditor.EditorApplication.isPlaying = false; //Cierra el editor
        Application.Quit();
    }
}
