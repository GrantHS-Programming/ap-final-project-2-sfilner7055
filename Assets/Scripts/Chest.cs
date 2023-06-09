using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int coinAmount = 10;
    protected override void OnCollect()
    {
        if(!collected){
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            //+5 coins
            GameManager.instance.ShowText("+" + coinAmount + " gold.", 20, Color.yellow, gameObject.transform.position, Vector3.up * 25, 1.5f);
        }
    }

}
