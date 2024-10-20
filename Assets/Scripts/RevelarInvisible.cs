using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;


public class RevelarInvisible : MonoBehaviour
{

    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private TilemapRenderer tilemapRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GameObject.Find("MensajeInvisible").GetComponent<MeshRenderer>();
        tilemapRenderer = GameObject.Find("TechoInvisible").GetComponent<TilemapRenderer>();
        meshRenderer.enabled = false;
        tilemapRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            if (meshRenderer != null)
                meshRenderer.enabled = true;

            if (tilemapRenderer != null)
                tilemapRenderer.enabled = true;
        }
    }
}
