using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{

    [SerializeField] Rigidbody2D r;
    [SerializeField] BoxCollider2D piesCollider;
    [SerializeField] CapsuleCollider2D personajeCollider;
    [SerializeField] CanvasGroup cGroupGameOver;
    [SerializeField] CanvasGroup cGroupUI;
    [SerializeField] AudioSource audioSaltos;

    [SerializeField] Animator anim;
    float movimientoX = 0f;
    float velocidad = 4.5f;
    bool ultimaDireccion = true;
    //float ultimaAltura = 0f;
    bool tecladoHabilitado = true;
    bool quiereSaltar = false;
    bool tocandoSuelo = false;
    bool puedeAtacar = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(2);
        
        cGroupGameOver.alpha = 1f;
        cGroupGameOver.interactable = true;
        cGroupGameOver.blocksRaycasts = true;

        cGroupUI.alpha = 0f;
        cGroupUI.interactable = false;
        cGroupUI.blocksRaycasts = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (CharacterVidaMana.vida < 1) {
            tecladoHabilitado = false;
            
        
            //Input.ResetInputAxes();
            movimientoX = 0f;
            anim.SetBool("muerto", true);
            StartCoroutine(MyCoroutine());

        }

        /*
        if (ultimaAltura > this.gameObject.transform.y) {
            anim.SetBool("cayendo", true);
        } else {
            ultimaAltura = this.gameObject.transform.y;
        }
*/
        if (tecladoHabilitado) {
            movimientoX = Input.GetAxis("Horizontal");
        }
        anim.SetBool("hayMovimiento", hayMovimiento());
        anim.SetBool("direccion", calcularDireccion());

        if (Input.GetKeyDown(KeyCode.Space) && tocandoSuelo) {
            quiereSaltar = true;
        }

        if (Input.GetKeyDown(KeyCode.H) && tocandoSuelo && puedeAtacar) {
            anim.SetBool("atacando", true);
            GetComponent<AudioSource>().Play();
            StartCoroutine(corutinaAtacar());
        } else {
            anim.SetBool("atacando", false);
        }

        anim.SetBool("saltando", !tocandoSuelo);

    }

    IEnumerator corutinaAtacar()
    {
        puedeAtacar = false;
        yield return new WaitForSeconds(0.7f);
        puedeAtacar = true;
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        r.velocity = new Vector2(movimientoX * velocidad, r.velocity.y);

        if (quiereSaltar) {
            tocandoSuelo = false;
            audioSaltos.Play();
            r.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
            quiereSaltar = false;
        }
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Suelo" || other.gameObject.tag == "Trap") {
            tocandoSuelo = true;
        }
 
    }

    bool hayMovimiento() {
        if (r.velocity.x != 0)
        {
            return true;
        } else
        {
            return false;
        }
    }

    bool calcularDireccion() {
        if (movimientoX != 0) {
            if (movimientoX > 0) {
                ultimaDireccion = true;
            } else if (movimientoX < 0) {
                ultimaDireccion = false;
            }
        }
        return ultimaDireccion;   
    }


}
