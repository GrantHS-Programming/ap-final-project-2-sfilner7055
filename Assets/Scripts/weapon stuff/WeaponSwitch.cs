using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WeaponSwitch : MonoBehaviour
{
    
    //Weapon arraylist stuff
    public List<GameObject> weaponList = new List<GameObject>();
    int currentWeapon = 0;
    Animator anim;


    void Start()
    {
        //hiding weapons
        Hide("Sword_Red");
        Hide("Sword_Green");
        Hide("Lightning_Gun");

        //adding weapons to weaponlist
        if(GameObject.Find("Sword_Red") != null){
            Debug.Log("not null");
        }
        else if(GameObject.Find("Sword_Red") == null){
            Debug.Log("null");
        }
        else{
            Debug.Log("Other");
        }
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
                Hide(weaponList[currentWeapon].name.ToString());
                //weaponList[currentWeapon].SetActive(false);
                Show(weaponList[0].name.ToString());
                //weaponList[0].SetActive(true);
                currentWeapon = 0; 
        }
        if(Input.GetKeyDown("2")){
                Debug.Log("weapon 2 switch");
                Hide(weaponList[currentWeapon].name.ToString());
                //weaponList[currentWeapon].SetActive(false);
                Show(weaponList[1].name.ToString());
                //weaponList[1].SetActive(true);
                currentWeapon = 1; 
        }
        if(Input.GetKeyDown("3")){
                Debug.Log("weapon 3 switch");
                Hide(weaponList[currentWeapon].name.ToString());
                //weaponList[currentWeapon].SetActive(false);
                Show(weaponList[2].name.ToString());
                //weaponList[2].SetActive(true);
                currentWeapon = 2; 
        }


        //for later
                /*if(Input.GetKeyDown("r")){
                    if(weaponList.Count < 3){
                        weaponList.Add(GameObject.Find(name));
                    }
                    
                }*/
    }

    void Hide(String gameObject){
        GameObject.Find (gameObject).transform.localScale = new Vector3(0, 0, 0);
    }

    void Show(String gameObject){
        GameObject.Find (gameObject).transform.localScale = new Vector3(0.7f, 0.7f, 0.0f);
    }
}
