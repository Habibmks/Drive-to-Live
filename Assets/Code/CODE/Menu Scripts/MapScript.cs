using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MapScript : MonoBehaviour
{

    public TextMeshProUGUI mapText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mapRight(){
        if(PlayerLobbyScript.map){
            PlayerLobbyScript.map = false;
            mapTextChange();
        }else {
            PlayerLobbyScript.map = true;
            mapTextChange();
        }
    }

    public void mapLeft(){
        if(PlayerLobbyScript.map){
            PlayerLobbyScript.map = false;
            mapTextChange();
        }else {
            PlayerLobbyScript.map = true;
            mapTextChange();
        }
    }

    public void mapTextChange(){
        if(mapText.text == "Forest"){
            mapText.text = "Snow";
        }else{
            mapText.text = "Forest";
        }
    }
}
