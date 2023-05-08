using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Mover
{
    //Exprience
    public int xpValue = 1;


    //Logic
    public float triggerLength = 0.3f;
    public float chaseLength = 1.0f;
    private bool chasing;
    private bool collWithPlayer;
    private Transform playerTransform;
    private Vector3 startPos;

    //Hitbox
    private BoxCollider2D hitbox;
    private Collider2D[] hits = new Collider2D[10];
    public ContactFilter2D filter;

    protected override void Start()
    {
        base.Start();
        playerTransform = GameManager.instance.player.transform;
        startPos = transform.position;
        hitbox = transform.GetChild(0).GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate(){
        //is the player in range?
        if(Vector3.Distance(playerTransform.position, startPos) < chaseLength){
            Debug.Log("Chase length.");
            if(Vector3.Distance(playerTransform.position, startPos) < triggerLength){
                Debug.Log("trigger length");
                chasing = true;
            }
            if(chasing){
                if(!collWithPlayer){
                    UpdateMotor((playerTransform.position - transform.position).normalized);
                }
            }
            else{
                UpdateMotor(startPos - transform.position);
            }
        }
        else{
            UpdateMotor(startPos - transform.position);
            chasing = false;
        }

        //See if enemy is touching player
        collWithPlayer = false;
        boxCollider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null){
                continue;
            }
            if(hits[i].tag == "Fighter" && hits[i].name == "Player"){
                    collWithPlayer = true;
                }

            //the array isn't cleaned up every time so we gotta do it ourselves
            hits[i] = null;
        }
    }

    protected override void Death()
    {
        Destroy(gameObject);
        GameManager.instance.experience += xpValue;
        GameManager.instance.ShowText("+ " + xpValue + " Soul Energy", 15, Color.magenta, transform.position, Vector3.up * 20, 1.0f);
    }
}
