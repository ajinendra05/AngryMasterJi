using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    int CurrentLevel=SceneManager.GetActiveScene().buildIndex;
    
    public void pass()
    {
        //Levelunlocked = PlayerPrefs.GetInt("Levelunlocked",1);
        if(CurrentLevel>=PlayerPrefs.GetInt("Levelunlocked"))
        {
            PlayerPrefs.SetInt("Levelunlocked",CurrentLevel+1);
        }
    }
  
    
}
