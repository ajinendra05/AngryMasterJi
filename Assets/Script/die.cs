using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{ 
    private int s;
    public GameObject face;
    public GameObject pettrn;

    void start()
    {  /*if(!PlayerPrefs.HasKey("score"))
       {
       PlayerPrefs.SetInt("score",0);
       }*/
        s=PlayerPrefs.GetInt("score",0);
        face= GetComponent<GameObject>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="ground")
        {
            StartCoroutine( destroy());
        }
        if(collision.collider.tag=="g1")
        {
            StartCoroutine( destroy());
        }
        if(collision.collider.tag=="g2")
        {
            StartCoroutine( destroy());
        }
        
    }
    void Update()
    {
        s=PlayerPrefs.GetInt("score",0);
       // Debug.Log(s);
    }
    public IEnumerator destroy()
    { 
        yield return new WaitForSeconds(2f);
      Destroy(face);
      Instantiate(pettrn,transform.position,Quaternion.identity);
      PlayerPrefs.SetInt("score",s+5);
     // Debug.Log(PlayerPrefs.GetInt("score",0));
    }
}
