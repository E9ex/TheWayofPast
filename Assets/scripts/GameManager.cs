
using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     private bool gameHasEnded = false;
     private float restartdelay = 1f;
     public GameObject completelevelui;
     public void CompleteLevel()
     {
        completelevelui.SetActive(true);
          
     }

     public void Endgame()
     {
          if (gameHasEnded == false)
          {
               gameHasEnded = true;
               Debug.Log("game over.");
               Invoke("restart",restartdelay);
          }
     }

     void restart()
     {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);//restart attıgında basa sarsin.
     }

}
