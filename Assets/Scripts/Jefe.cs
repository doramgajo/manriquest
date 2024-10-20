using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jefe : MonoBehaviour
{

    private Animator animator;
    public Rigidbody2D rb;
    private Transform jugador;
    private bool mirandoDerecha = false;

    private float vida = 20;
    [SerializeField] public GameObject prefab;
    [SerializeField] AudioSource victoriaMusic;
    private int danioAtaque = 1;

    // Start is called before the first frame update
    void Start()
    {
        
        GameObject.Find("Particulas golpes boss").GetComponent<ParticleSystem>().Stop();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void recibirDanio(float danio)
    {
        vida -= danio;

        if (vida <= 0)
        {
            animator.SetTrigger("Muerte");
            StartCoroutine(Muerte());

        }

    }

    IEnumerator Muerte()
    {
        victoriaMusic.Play();

        for (int i = 0; i < 10; i++) {
        //GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(4);

        Destroy(gameObject);
        
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void mirarJugador()
    {
        if ((jugador.position.x > transform.position.x && !mirandoDerecha) || (jugador.position.x < transform.position.x && mirandoDerecha))
        {
            mirandoDerecha = !mirandoDerecha;
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        }
    }

    public void iniciarBoss() {
            animator.SetTrigger("iniciarBoss");
    }

    // Update is called once per frame
    void Update()
    {
        mirarJugador();
        float distanciaJugador = Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);
        Debug.Log(distanciaJugador);
        animator.SetFloat("distanciaJugador", distanciaJugador);
    }

    void OnTriggerEnter2D(Collider2D other)//
    {
            if (other.CompareTag("Player"))
            {
                GameObject.Find("Sonidos golpes").GetComponent<AudioSource>().Play();
                GameObject.Find("Particulas golpes boss").GetComponent<ParticleSystem>().Play();
                CharacterVidaMana.vida--;
            }
    }
}
