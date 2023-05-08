using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FloatingText
{
    //variables
    public bool active;
    public GameObject go;
    public  TextMeshProUGUI txt;
    public Vector3 motion;
    public float duration;
    public float lastShown;

    //functions
    public void Show(){
        active = true;
        lastShown = Time.time;
        go.SetActive(active);
    }

    public void Hide(){
        active = false;
        go.SetActive(active);
    }

    public void UpdateFloatingText(){
        if(!active){
            return;
        }
        //to know if the text has been shown for too long. If current time - the time the text last appeared is greater than its duration, the text hides.
        if(Time.time - lastShown > duration){
            Hide();
        }
        go.transform.position += motion * Time.deltaTime;
    }
}
