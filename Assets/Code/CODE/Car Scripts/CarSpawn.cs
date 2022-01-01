using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject FirstCar;
    public GameObject SecondCar;
    public bool fcar;
    public bool scar;
    // Start is called before the first frame update
    void Start()
    {
        if (fcar)
        {
            Destroy(SecondCar);
        }
        if (scar)
        {
            Destroy(FirstCar);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
