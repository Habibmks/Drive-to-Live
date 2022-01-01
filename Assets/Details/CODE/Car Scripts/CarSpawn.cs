using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject FirstCar;
    public GameObject SecondCar;
    // Start is called before the first frame update
    void Start()
    {
        GameObject fCar = Instantiate(FirstCar) as GameObject;
        GameObject sCar = Instantiate(SecondCar) as GameObject;
        fCar.transform.position = new Vector2(-9, 3);
        sCar.transform.position = new Vector2(-9, 3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
