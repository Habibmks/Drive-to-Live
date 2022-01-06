using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuSwitch : MonoBehaviour
{
    public void Menu(){
        SceneManager.LoadScene(0);
    }

    public void Lobby(){
        SceneManager.LoadScene(1);
    }

    public void PlayerLobby(){
        SceneManager.LoadScene(2);
    }

    public void EndScene(){
        SceneManager.LoadScene(3);
    }

    public void StoryScene(){
        SceneManager.LoadScene(4);
    }

    public void ForestScene(){
        SceneManager.LoadScene(5);
    }

    public void SnowScene(){
        SceneManager.LoadScene(6);
    }

    public void Quit(){
        Application.Quit();
    }
}
