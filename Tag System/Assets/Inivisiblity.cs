using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inivisiblity : MonoBehaviour
{
    private Renderer rend;

    [SerializeField]
    private Color newColor = Color.clear;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        rend.material.color = newColor;
    }

}
