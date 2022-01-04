using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScripts : MonoBehaviour
{
    
    public static int p1 = 1;
    public static int p2 = 1;

    public LobbyScripts(){
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void startButton(){
        //p1 = p1index;
        //p2 = p2index;
    }

    public void RandomButton(){
        int P1Rnd = Random.Range(1,5), P2Rnd = Random.Range(1,5);
        p1 = P1Rnd;
        p2 = P2Rnd;
        Debug.Log(p1);
        Debug.Log(p2);
        SceneManager.LoadScene(3);
    }
    
}
