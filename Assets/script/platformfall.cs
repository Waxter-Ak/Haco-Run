using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformfall : MonoBehaviour
{
    private Rigidbody2D r;
    private void Start()
    {
        
        r = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "player")
        {


            
            //transform.position = new Vector2(0, 50); 
            Die();
            Dest();

        }
    }
    private void Die()
    {
        r.bodyType = RigidbodyType2D.Dynamic;
        if(r.freezeRotation == false)
            r.freezeRotation = true;
        
        

    }
    private void Dest()
    {
        Destroy(gameObject,.8f); 
    }

}
