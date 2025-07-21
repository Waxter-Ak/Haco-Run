using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{
    private PlayerLife gameover;
    private void Start()
    {
        gameover = FindObjectOfType<PlayerLife>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameover.Die();
        }
    }
}
