using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] CanvasGroup canvasGroupMenu;
    [SerializeField] CanvasGroup canvasGroupCreditos;

    public void iniciarAventura(string nivel) {
        SceneManager.LoadScene(nivel);
    }

    public void iniciarCreditos() {
        canvasGroupCreditos.alpha = 1f;
        canvasGroupCreditos.interactable = true;
        canvasGroupCreditos.blocksRaycasts = true;

        canvasGroupMenu.alpha = 0f;
        canvasGroupMenu.interactable = false;
        canvasGroupMenu.blocksRaycasts = false;
    }

    public void finalizarCreditos() {
        canvasGroupCreditos.alpha = 0f;
        canvasGroupCreditos.interactable = false;
        canvasGroupCreditos.blocksRaycasts = false;

        canvasGroupMenu.alpha = 1f;
        canvasGroupMenu.interactable = true;
        canvasGroupMenu.blocksRaycasts = true;
    }

    public void salirDelJuego() {
        Application.Quit();
    }
}
