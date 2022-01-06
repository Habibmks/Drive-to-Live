using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLobbyScript : MonoBehaviour
{



    public static int player1 = 120, player2 = 120;
    public static bool map = true;
    
    public GameObject P1_1;
    public GameObject P1_2;
    public GameObject P1_3;
    public GameObject P1_4;
    
    public GameObject P2_1;
    public GameObject P2_2;
    public GameObject P2_3;
    public GameObject P2_4;

    // Start is called before the first frame update
    void Start()
    {
        
            P1_1.SetActive(true);
            P1_2.SetActive(false);
            P1_3.SetActive(false);
            P1_4.SetActive(false);

            P2_1.SetActive(true);
            P2_2.SetActive(false);
            P2_3.SetActive(false);
            P2_4.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1R(){
        ChangeP1(true);
    }

    public void Player1L(){
        ChangeP1(false);
    }

    public void Player2R(){
        ChangeP2(true);
    }

    public void Player2L(){
        ChangeP2(false);
    }

    public void StartButton(){
        LobbyScripts.p1 = (player1%4) +1;
        LobbyScripts.p2 = (player2%4) +1;
        if(map){
            SceneManager.LoadScene(5);
        }else{
            SceneManager.LoadScene(6);
        }
    }

    public void ChangeP1(bool op){
        int temp = player1;
        if(op){
            player1++;
            temp=player1%4;
        }else{
            player1--;
            temp=player1%4;
        }
        Debug.Log(player1);
        P1Image(temp);


    }

    public void ChangeP2(bool op){
        int temp = player2;
        if(op){
            player2++;
            temp=player2%4;
        }else{
            player2--;
            temp=player2%4;
        }
        Debug.Log(player2);
        P2Image(temp);
    }

    public void P1Image(int id){
        if(id<0){id=id+4;}
        switch(id){
            case 0:
            P1_1.SetActive(true);
            P1_2.SetActive(false);
            P1_3.SetActive(false);
            P1_4.SetActive(false);
            break;
            case 1:
            P1_1.SetActive(false);
            P1_2.SetActive(true);
            P1_3.SetActive(false);
            P1_4.SetActive(false);
            break;
            case 2:
            P1_1.SetActive(false);
            P1_2.SetActive(false);
            P1_3.SetActive(true);
            P1_4.SetActive(false);
            break;
            case 3:
            P1_1.SetActive(false);
            P1_2.SetActive(false);
            P1_3.SetActive(false);
            P1_4.SetActive(true);
            break;
            default:
            P1_1.SetActive(true);
            P1_2.SetActive(false);
            P1_3.SetActive(false);
            P1_4.SetActive(false);
            break;
        }
    }

    public void P2Image(int id){
        if(id<0){id=id+4;}
        switch(id){
            case 0:
            P2_1.SetActive(true);
            P2_2.SetActive(false);
            P2_3.SetActive(false);
            P2_4.SetActive(false);
            break;
            case 1:
            P2_1.SetActive(false);
            P2_2.SetActive(true);
            P2_3.SetActive(false);
            P2_4.SetActive(false);
            break;
            case 2:
            P2_1.SetActive(false);
            P2_2.SetActive(false);
            P2_3.SetActive(true);
            P2_4.SetActive(false);
            break;
            case 3:
            P2_1.SetActive(false);
            P2_2.SetActive(false);
            P2_3.SetActive(false);
            P2_4.SetActive(true);
            break;
            default:
            P2_1.SetActive(true);
            P2_2.SetActive(false);
            P2_3.SetActive(false);
            P2_4.SetActive(false);
            break;
        }

    }
}
