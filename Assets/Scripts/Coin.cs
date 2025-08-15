using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    
    public static int monedas = 0;
    TextMeshProUGUI textoMonedas;
    [SerializeField] AudioSource audioMonedas;

    void Start() {
        textoMonedas = GameObject.Find("cantidadMonedas").GetComponent<TMPro.TextMeshProUGUI>();
        GameObject audioObject = GameObject.Find("Sonidos monedas");
        audioMonedas = audioObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            monedas++;
            audioMonedas.Stop();
            audioMonedas.Play();
            textoMonedas.text = $"{monedas}";            
            Destroy(this.gameObject);
        }
    }

}
