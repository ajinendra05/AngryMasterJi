using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectil1 : MonoBehaviour
{  
    public GameOverScreen gameOverScreen;
    private Rigidbody2D rb;
    private SpringJoint2D sj;
    private bool isPressed;
    private Camera cam;
    
    //public bool GetMouseButtonUp(int mouseButton){}

    // Start is called before the first frame update
    void Start()
    {   PlayerPrefs.SetInt("score",0);
       rb = GetComponent<Rigidbody2D>();
       sj = GetComponent<SpringJoint2D>();
       cam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        if(isPressed)
        {
            rb.position =  cam.ScreenToWorldPoint(Input.mousePosition);
             
          }
        
        if(Input.GetMouseButtonUp(0))
        {
         rb.isKinematic = false;
        isPressed=false;
        StartCoroutine(Release());
         StartCoroutine(Cll());



        }
        
    }

    private void OnMouseUP()
    {
        rb.isKinematic = false;
        isPressed=false;
        StartCoroutine(Release());
         StartCoroutine(Cll());


    }

    private void OnMouseDown()
    {
        rb.isKinematic = true;
        isPressed=true;
     }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(0.15f);
         GetComponent<SpringJoint2D>().enabled = false;
         
    }

     IEnumerator Cll()
     {
          yield return new WaitForSeconds(13f);
         gameover();
     }
     public void gameover()
    {
        
         gameOverScreen.Setup();

    }

    
}
