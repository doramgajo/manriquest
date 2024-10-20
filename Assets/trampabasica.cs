using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampabasica : MonoBehaviour
{

    void Start() {
        
        GetComponent<ParticleSystem>().Stop();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            if (other.CompareTag("Player"))
            {
                CharacterVidaMana.vida--;
                GameObject.Find("Sonidos golpes").GetComponent<AudioSource>().Play();
                GetComponent<ParticleSystem>().Play();
            }
    }
}
