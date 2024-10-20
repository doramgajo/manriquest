using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdooMate : MonoBehaviour
{

    
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioEntrar;
    [SerializeField] AudioClip audioSalir;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            audioSource.Stop();
            audioSource.clip = audioEntrar;
            audioSource.Play();
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            audioSource.Stop();
            audioSource.clip = audioSalir;
            audioSource.Play();
        }
    }

}
