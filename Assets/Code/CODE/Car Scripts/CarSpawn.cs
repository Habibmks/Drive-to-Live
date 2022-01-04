using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject FirstCar;
    public GameObject SecondCar;
    public GameObject Player1raceCar;
    public GameObject Player1Truck;
    public GameObject Player1itfaiye;
    public GameObject Player1Savas;

    public GameObject Player2raceCar;
    public GameObject Player2Truck;
    public GameObject Player2itfaiye;
    public GameObject Player2Savas;
    public bool fcar;
    public bool scar;
    public int carID;
    int player1, player2;
    public CarSpawn()
    {
        player1 = LobbyScripts.p1;
        player2 = LobbyScripts.p2;
    }
    // Start is called before the first frame update
    void Start()
    {
        /*switch(carID)
        {
            case 1:
                fcar = true;
                Destroy(SecondCar);
                break;
            case 2:
                scar = true;
                Destroy(FirstCar);
                break;

        }*/

        Debug.Log(player1);


        
            Destroy(SecondCar);
        
       
        
            Destroy(FirstCar);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
