using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject FirstCar;
    public GameObject SecondCar;
    public GameObject ThirdCar;
    public GameObject FourthCar;

    public GameObject FirstCarR;
    public GameObject SecondCarR;
    public GameObject ThirdCarR;
    public GameObject FourthCarR;


    public static int firstPlayer, secondPlayer;


    public CarSpawn()
    {
        firstPlayer = LobbyScripts.p1;
        secondPlayer = LobbyScripts.p2;
    }
    void Start()
    {
        Debug.Log(firstPlayer);
        Debug.Log(secondPlayer);
        switch (LobbyScripts.p1)
        {
            case 1:
                Destroy(SecondCar);
                Destroy(ThirdCar);
                Destroy(FourthCar);
                break;
            case 2:
                Destroy(FirstCar);
                Destroy(ThirdCar);
                Destroy(FourthCar);
                break;
            case 3:
                Destroy(FirstCar);
                Destroy(SecondCar);
                Destroy(FourthCar);
                break;
            case 4:
                Destroy(FirstCar);
                Destroy(SecondCar);
                Destroy(ThirdCar);
                break;
            default:

                break;
        }
        switch (LobbyScripts.p2)
        {
            case 1:
                Destroy(SecondCarR);
                Destroy(ThirdCarR);
                Destroy(FourthCarR);
                break;
            case 2:
                Destroy(FirstCarR);
                Destroy(ThirdCarR);
                Destroy(FourthCarR);
                break;
            case 3:
                Destroy(FirstCarR);
                Destroy(SecondCarR);
                Destroy(FourthCarR);
                break;
            case 4:
                Destroy(FirstCarR);
                Destroy(SecondCarR);
                Destroy(ThirdCarR);
                break;
            default:

                break;
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
