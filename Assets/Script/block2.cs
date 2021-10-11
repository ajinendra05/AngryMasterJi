using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block2 : MonoBehaviour
{
     public BoxCollider2D Block;
    

    void start()
    {
        Block= GetComponent<BoxCollider2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="ground")
        {
            StartCoroutine( destroy());
        }
        
        
    }
    public IEnumerator destroy()
    { 
        yield return new WaitForSeconds(1f);
         GetComponent<BoxCollider2D>().enabled = false;
    }
}
