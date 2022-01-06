using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScript : MonoBehaviour
{

    public TextMeshProUGUI winnerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CarSpawn.winner){
            winnerText.text = "Better Car Always Wins";
        }else{
            winnerText.text = "Better Car Always Wins";
        }
    }
}
