using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inGamePause : MonoBehaviour
{
    public void doExitGame() 
     {
          Debug.Log("QUIT");
          Application.Quit();
     }

    public void ExitGame ()
     {
          SceneManager.LoadScene(0);
     }

}
