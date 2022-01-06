using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScripts : MonoBehaviour
{
    
    public TextMeshProUGUI txt;
    

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
        SceneManager.LoadScene(1);
    }

    public void toPlayScene(){
        SceneManager.LoadScene(2);
    }

    public void LoadMenu(){
        SceneManager.LoadScene(0);
    }

    public void StoryButton(){
        SceneManager.LoadScene(4);
    }

    public void MuteButton(){
        if(txt.text == "Mute"){
            txt.text = "Unmute";
            AudioListener.pause = true;
        }else{
            txt.text = "Mute";
            AudioListener.pause = false;
        }
    }

}
