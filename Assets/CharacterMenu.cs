using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMenu : MonoBehaviour
{
    //Text fields
    public Text levelText, hpText, coinText, upgradeCostText, xpText, soulText;
    
    //Logic
    private int currentWeaponSelection = 0;
    private int oldWeapon = 0;
    public Image characterCollectionSprite;
    public Image weaponSprite;
    public RectTransform xpBar;

    //Weapon Selection
    public void onWeaponButtonClick(bool right, bool mid){
        if(right){
            oldWeapon = currentWeaponSelection;
            currentWeaponSelection = 2;

            OnSelectionChanged();
        }
        else if(mid){
            oldWeapon = currentWeaponSelection;
            currentWeaponSelection = 1;

            OnSelectionChanged();
            }
        else{
            oldWeapon = currentWeaponSelection;
            currentWeaponSelection = 0;

            OnSelectionChanged();
        }

    }
    private void OnSelectionChanged(){
        //GameObject.setActive(true) for the new one, false for old one
    }
}
