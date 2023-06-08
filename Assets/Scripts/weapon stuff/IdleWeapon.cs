using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleWeapon : MonoBehaviour
{

    Transform tempTransform;

    GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.Find("floorWeapons");

        tempTransform = this.transform;
        this.transform.SetParent(GameObject.Find("floorWeapons").transform, false);
        //this.transform = tempTransform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
