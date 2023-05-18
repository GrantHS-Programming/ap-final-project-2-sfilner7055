using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    bool show = false;
    bool hide = true;

    Animator anim;
    protected void Update(){
        if(Input.GetKeyDown(KeyCode.Tab)){
            if(hide){
                anim.SetTrigger("show");
                show = true;
                hide = false;
            }
            if(show){
                anim.SetTrigger("show");
                show = false;
                hide = true;
                anim.SetTrigger("hide");
            }

        }

    }
}
