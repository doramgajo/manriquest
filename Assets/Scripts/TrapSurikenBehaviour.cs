using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSurikenBehaviour : MonoBehaviour
{

    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] Animator anim;
    [SerializeField] CircleCollider2D collider;
    

    void Start() {
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            
            anim.SetBool("sangre", true);
            particleSystem.Play();
            CharacterVidaMana.vida -= 4;//////
            Destroy(collider);
    } else if (other.gameObject.tag == "gato") {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,5), ForceMode2D.Impulse);
            other.gameObject.GetComponent<AudioSource>().Play();
            anim.SetBool("sangre", true);
            other.gameObject.GetComponent<Animator>().SetBool("muerto", true);
            particleSystem.Play();
    }

    }
}
