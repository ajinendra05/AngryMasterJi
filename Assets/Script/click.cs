using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click : MonoBehaviour
{
     private int LevelToPlay; 
     
     public void start()
     { 
         if(!PlayerPrefs.HasKey("LevelToPlay"))
         {
             PlayerPrefs.SetInt("LevelToPlay",2);
         }
         LevelToPlay = PlayerPrefs.GetInt("LevelToPlay",2);
     }
   public void play()
   {
        LevelToPlay = PlayerPrefs.GetInt("LevelToPlay",2);
       SceneManager.LoadScene(LevelToPlay);
       Debug.Log(LevelToPlay);
   }
   public void level()
   {
       SceneManager.LoadScene("Levels");
   }
    public void Back()
   {
       SceneManager.LoadScene("Menu");
   }

   public void next()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   public void replay()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
   public void quit()
   {
       Application.Quit();
   }
   
}
