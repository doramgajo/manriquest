using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corazones : MonoBehaviour
{

    [SerializeField] AudioSource audioCorazones;

    // Start is called before the first frame update
    void Start()
    {
        GameObject audioObject = GameObject.Find("Sonidos corazones");
        audioCorazones = audioObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            if (CharacterVidaMana.vida < 4) {
                CharacterVidaMana.vida++;
            Destroy(this.gameObject);
            audioCorazones.Play();
            }
    }
    }
}
