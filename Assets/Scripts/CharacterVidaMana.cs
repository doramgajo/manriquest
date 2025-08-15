using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterVidaMana : MonoBehaviour
{
    public static int vida = 3;
    [SerializeField] Image vida1;
    [SerializeField] Image vida2;
    [SerializeField] Image vida3;
    [SerializeField] Image vida4;
    public Sprite vidaLlena;
    public Sprite vidaVacia;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (vida)
        {
            case 0:
                vida1.sprite = vidaVacia;
                vida2.sprite = vidaVacia;
                vida3.sprite = vidaVacia;
                vida4.sprite = vidaVacia;
                break;
            case 1:
                vida1.sprite = vidaLlena;
                vida2.sprite = vidaVacia;
                vida3.sprite = vidaVacia;
                vida4.sprite = vidaVacia;
                break;
            case 2:
                vida1.sprite = vidaLlena;
                vida2.sprite = vidaLlena;
                vida3.sprite = vidaVacia;
                vida4.sprite = vidaVacia;
                break;
            case 3:
            
                vida1.sprite = vidaLlena;
                vida2.sprite = vidaLlena;
                vida3.sprite = vidaLlena;
                vida4.sprite = vidaVacia;
                break;
            case 4:
                vida1.sprite = vidaLlena;
                vida2.sprite = vidaLlena;
                vida3.sprite = vidaLlena;
                vida4.sprite = vidaLlena;
                break;
            default:
                vida1.sprite = vidaVacia;
                vida2.sprite = vidaVacia;
                vida3.sprite = vidaVacia;
                vida4.sprite = vidaVacia;
                break;
        }
    }


}
