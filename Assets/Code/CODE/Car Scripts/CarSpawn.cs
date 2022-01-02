using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject FirstCar;
    public GameObject SecondCar;
    public bool fcar;
    public bool scar;
    public int carID;
    public CarSpawn(int carID)
    {
        this.carID = carID;
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

        
            Destroy(SecondCar);
        
       
        
            Destroy(FirstCar);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
