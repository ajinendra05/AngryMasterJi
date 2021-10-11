using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{   
    [SerializeField] Slider s;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {  
        audioSource.GetComponent<AudioSource>();
       if(!PlayerPrefs.HasKey("Volume"))
       {
           PlayerPrefs.GetFloat("Volume",1);
           s.value=1;
           load();
       } 
       else
       {
           load();

       }
    }
    
     public void ChangeVolume()
    {
      audioSource.volume=s.value;
        save();
    }
     private void save()
    {
       PlayerPrefs.SetFloat("Volume",s.value);
    }
    
    private void load()
    {
        s.value=PlayerPrefs.GetFloat("Volume");
        //ChangeVolume();
    }
   
}
