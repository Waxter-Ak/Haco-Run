using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibleSpikes : MonoBehaviour
{

    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           sr.enabled = true;
        }
    }
   
}
