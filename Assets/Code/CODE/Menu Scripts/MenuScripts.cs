using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame(){
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void toPlayerLobby(){
        SceneManager.LoadScene(2);
    }

    public void toPlayScene(){
        SceneManager.LoadScene(3);
    }

    public void LoadMenu(){
        SceneManager.LoadScene(0);
    }

    public void StoryButton(){
        
    }

}