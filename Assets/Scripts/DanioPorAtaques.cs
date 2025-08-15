using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanioPorAtaques : MonoBehaviour
{

    [SerializeField] public GameObject prefab;
    [SerializeField] public GameObject corazon;
    [SerializeField] GameObject modoTruco;

    void OnTriggerEnter2D(Collider2D  other) {
        if (other.CompareTag("Enemy")) {
            GameObject.Find("Sonidos golpes").GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            soltarDineros();
        } else if (other.CompareTag("Boss")) {
            other.gameObject.GetComponent<Jefe>().recibirDanio(1);
            GameObject.Find("Sonidos golpes").GetComponent<AudioSource>().Play();
            soltarDineros();
            int numeroAleatorio = UnityEngine.Random.Range(0, 5);
            if (numeroAleatorio == 0)
                {
                    soltarCorazon();
                }
            
        } else if (other.CompareTag("activarDEV")) {
            GameObject.Find("Sonidos golpes").GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            
            modoTruco.GetComponent<BoxCollider2D>().enabled = true;
            modoTruco.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    void soltarDineros() {
            GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity);
        }

        void soltarCorazon() {
            GameObject obj = Instantiate(corazon, transform.position, Quaternion.identity);
        }
    }


