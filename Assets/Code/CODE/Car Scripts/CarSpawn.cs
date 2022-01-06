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

    public static bool winner = true;


    public GameObject FirstCarHB1;
    public GameObject SecondCarHB1;
    public GameObject ThirdCarHB1;
    public GameObject FourthCarHB1;

    public GameObject FirstCarHB2;
    public GameObject SecondCarHB2;
    public GameObject ThirdCarHB2;
    public GameObject FourthCarHB2;



    public GameObject FirstCarSC1;
    public GameObject SecondCarSC1;
    public GameObject ThirdCarSC1;
    public GameObject FourthCarSC1;

    public GameObject FirstCarSC2;
    public GameObject SecondCarSC2;
    public GameObject ThirdCarSC2;
    public GameObject FourthCarSC2;

    public static int firstPlayer, secondPlayer;
    public GameObject muziko;


    public CarSpawn()
    {
        firstPlayer = LobbyScripts.p1;
        secondPlayer = LobbyScripts.p2;
    }
    void Start()
    {
        Debug.Log(firstPlayer);
        Debug.Log(secondPlayer);
        Destroy(BcMusicScript.bcMusicScript);
        switch (LobbyScripts.p1)
        {
            case 1:
                Destroy(SecondCar);
                Destroy(ThirdCar);
                Destroy(FourthCar);
                Destroy(SecondCarHB1);
                Destroy(ThirdCarHB1);
                Destroy(FourthCarHB1);
                Destroy(SecondCarSC1);
                Destroy(ThirdCarSC1);
                Destroy(FourthCarSC1);
                break;
            case 2:
                Destroy(FirstCar);
                Destroy(ThirdCar);
                Destroy(FourthCar);
                Destroy(ThirdCarHB1);
                Destroy(FourthCarHB1);
                Destroy(FirstCarHB1);
                Destroy(ThirdCarSC1);
                Destroy(FourthCarSC1);
                Destroy(FirstCarSC1);
                break;
            case 3:
                Destroy(FirstCar);
                Destroy(SecondCar);
                Destroy(FourthCar);
                Destroy(FourthCarHB1);
                Destroy(FirstCarHB1);
                Destroy(SecondCarHB1);
                Destroy(FourthCarSC1);
                Destroy(FirstCarSC1);
                Destroy(SecondCarSC1);
                break;
            case 4:
                Destroy(FirstCar);
                Destroy(SecondCar);
                Destroy(ThirdCar);
                Destroy(FirstCarHB1);
                Destroy(SecondCarHB1);
                Destroy(ThirdCarHB1);
                Destroy(FirstCarSC1);
                Destroy(SecondCarSC1);
                Destroy(ThirdCarSC1);
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
                Destroy(SecondCarHB2);
                Destroy(ThirdCarHB2);
                Destroy(FourthCarHB2);
                Destroy(SecondCarSC2);
                Destroy(ThirdCarSC2);
                Destroy(FourthCarSC2);
                break;
            case 2:
                Destroy(FirstCarR);
                Destroy(ThirdCarR);
                Destroy(FourthCarR);
                Destroy(ThirdCarHB2);
                Destroy(FourthCarHB2);
                Destroy(FirstCarHB2);
                Destroy(ThirdCarSC2);
                Destroy(FourthCarSC2);
                Destroy(FirstCarSC2);
                break;
            case 3:
                Destroy(FirstCarR);
                Destroy(SecondCarR);
                Destroy(FourthCarR);
                Destroy(FourthCarHB2);
                Destroy(FirstCarHB2);
                Destroy(SecondCarHB2);
                Destroy(FourthCarSC2);
                Destroy(FirstCarSC2);
                Destroy(SecondCarSC2);
                break;
            case 4:
                Destroy(FirstCarR);
                Destroy(SecondCarR);
                Destroy(ThirdCarR);
                Destroy(FirstCarHB2);
                Destroy(SecondCarHB2);
                Destroy(ThirdCarHB2);
                Destroy(FirstCarSC2);
                Destroy(SecondCarSC2);
                Destroy(ThirdCarSC2);
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
