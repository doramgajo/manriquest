using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class puerta1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
            {
                Debug.Log("Player");
                SceneManager.LoadScene("Mapa2");
            } else {
                Debug.Log("NOPlayer");
            }
    }
}
