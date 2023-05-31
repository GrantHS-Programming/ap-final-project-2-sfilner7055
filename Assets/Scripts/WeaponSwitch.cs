using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    
    //Weapon arraylist stuff
    public List<GameObject> weaponList = new List<GameObject>();
    int currentWeapon = 0;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        weaponList.Add(GameObject.Find("Sword_Red"));
        weaponList.Add(GameObject.Find("Sword_Green"));
        weaponList.Add(GameObject.Find("Lightning_Gun"));
    }

    // Update is called once per frame
    void Update()
    {
        
        //switching weapons

        if(Input.GetKeyDown("1")){
                Debug.Log("weapon 1 switch");
                weaponList[currentWeapon].SetActive(false);
                weaponList[0].SetActive(true);
                currentWeapon = 0; 
        }
        if(Input.GetKeyDown("2")){
                Debug.Log("weapon 2 switch");
                weaponList[currentWeapon].SetActive(false);
                weaponList[1].SetActive(true);
                currentWeapon = 1;
        }
        if(Input.GetKeyDown("3")){
                Debug.Log("weapon 3 switch");
                weaponList[currentWeapon].SetActive(false);
                weaponList[2].SetActive(true);
                currentWeapon = 2;
        }


        //for later
                /*if(Input.GetKeyDown("r")){
                    if(weaponList.Count < 3){
                        weaponList.Add(GameObject.Find(name));
                    }
                    
                }*/
    }
}
