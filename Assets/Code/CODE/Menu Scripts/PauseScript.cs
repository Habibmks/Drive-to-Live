using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool pause = false;
    public GameObject pauseMenu;
    public bool isPause = false;

    private void Start (){

    }

    private void Update(){

         if (Input.GetKeyDown("escape"))
            {
              pauseButton();
              Debug.Log("Escape");
            }
        
    }

    public void pauseButton(){
        if(pause){
            Resume();
            pause = false;
        }else{
            Pause();
            pause = true;
        }
    }

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void Quit(){
        Application.Quit();
    }
}
