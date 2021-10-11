using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LEVELCHANGER : MonoBehaviour
{  
    int Levelunlocked ; 
   
  public Button[] lvlButtons;

    // Start is called before the first frame update
    /*void Start()
    {
        Levelunlocked = PlayerPrefs.GetInt("Levelunlocked",1);
     //   int levelAt = PlayerPrefs.GetInt("levelAt", 2); 
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i  > Levelunlocked)
                lvlButtons[i].interactable = false;
        }
    }*/
    public void loadlevel( int levelindex)
    {
        //SceneManager.LoadScene(levelindex);
        PlayerPrefs.SetInt("LevelToPlay",levelindex);
       // Debug.Log(PlayerPrefs.GetInt("LevelToPlay",2));
    }


}
