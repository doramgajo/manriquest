using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarboss : MonoBehaviour
{

[SerializeField] Animator animBoss;

    void OnTriggerEnter2D(Collider2D other)
    {
            animBoss.SetTrigger("iniciarBoss");
    }
}
