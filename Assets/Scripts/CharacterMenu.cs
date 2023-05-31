using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMenu : MonoBehaviour
{
    //Text fields
    public Text levelText, hpText, coinText, upgradeCostText, xpText, soulText;
    
    //Logic
    private int currentWeapon = 0;
    private int oldWeapon = 0;
    public Image characterCollectionSprite;
    public Image weaponSprite;
    public RectTransform xpBar;

    //Weapon Selection
    public void onWeaponButtonClick(bool right, bool mid){
        if(right){
            oldWeapon = currentWeapon;
            currentWeapon = 2;

            OnSelectionChanged();
        }
        else if(mid){
            oldWeapon = currentWeapon;
            currentWeapon = 1;

            OnSelectionChanged();
            }
        else{
            oldWeapon = currentWeapon;
            currentWeapon = 0;

            OnSelectionChanged();
        }

    }
    private void OnSelectionChanged(){

        //GameObject.setActive(true) for the new one, false for old one
    }
}
