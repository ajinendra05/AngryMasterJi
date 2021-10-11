using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameOverScreen : MonoBehaviour
{ public int score;
    // Start is called before the first frame update
    public TMP_Text point;
    void Start()
    {
score=PlayerPrefs.GetInt("score",0);
Debug.Log(PlayerPrefs.GetInt("score",0));
    }
   public void Setup()
   {
       gameObject.SetActive(true);
       score=PlayerPrefs.GetInt("score",0);
       Debug.Log(PlayerPrefs.GetInt("score",0));
       point.text=score.ToString()+" POINTS";
   }

}
