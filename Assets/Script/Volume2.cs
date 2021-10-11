using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume2 : MonoBehaviour
{   public AudioSource s;
    private float Volume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        s=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       s.volume = Volume;
    }
    public void Change( float value)
    {
        Volume=value;
    }
}
