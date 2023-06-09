using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleWeapon : MonoBehaviour
{

    Vector3 tempTransform;

    GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.Find("floorWeapons");

        tempTransform = this.transform.position;
        Debug.Log(tempTransform);
        if(tempTransform == this.transform.position){
            Debug.Log("first oen worked");
        }
        this.transform.SetParent(GameObject.Find("floorWeapons").transform);
        this.transform.position = tempTransform;
        if(this.transform.position == tempTransform){
            Debug.Log("temptransform");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
