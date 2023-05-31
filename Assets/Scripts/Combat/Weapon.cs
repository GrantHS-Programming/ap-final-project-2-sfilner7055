using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Weapon : Collidable
{
   //Damage struct
   public int damagePoint = 1;
   public float pushForce = 4.0f;

   //"Upgrades" a.k.a. other weapons.
   public int weaponType = 0;
   private SpriteRenderer SpriteRenderer;


    //Swing variables
    private Animator anim;
    private float cooldown = 0.25f;
    private float lastSwing;

    

    //Starting
    protected override void Start()
    {
        base.Start();


        SpriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
    }

    //Update
    protected override void Update()
    {

        base.Update();
        //If the time since last mouse click is more than the cooldown, you can swing again.
        if(Input.GetMouseButtonDown(0)){
            if(Time.time - lastSwing > cooldown){
                lastSwing = Time.time;
                Swing();
            }
        }
        
        
    }

    protected override void OnCollide(Collider2D coll)
    {
        if(coll.tag == "Fighter"){
            if(coll.name == "Player"){
                return;
            }
            //Create new damage object & send it to enemy
            Damage dmg = new Damage{
                damageAmount = damagePoint,
                origin = transform.position,
                pushForce = pushForce
            };
            
            coll.SendMessage("RecieveDamage", dmg);
        }
    }


    private void Swing(){
        anim.SetTrigger("Swing");
    }
}
