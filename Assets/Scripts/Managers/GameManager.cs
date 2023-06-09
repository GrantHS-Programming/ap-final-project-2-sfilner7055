using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake(){
        if(GameManager.instance != null){
            Destroy(gameObject);
            return;
        }
        //To reset player prefs (money, xp, etc) run code once with this.
        //PlayerPrefs.DeleteAll();
        
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    //Resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    //References
    public Player player;
    //public Weapon soulEater;
    public FloatingTextManager floatingTextManager;

    //Logic
    public int money;
    public int experience;

    //Floating text!
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration){
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }


    //Save State
    /*
    * int money
    *int experience
    *int weaponLevel
    */
    public void SaveState(){
        Debug.Log("SaveState");
        string s = "";
        s += "0" + "|";
        s += money.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0";

        PlayerPrefs.SetString("SaveState", s);
    }
    public void LoadState(Scene s, LoadSceneMode mode){
        if(!PlayerPrefs.HasKey("SaveState")){
            return;
        }

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        //Change Player Skin
        money = int.Parse(data[1]);
        experience = int.Parse(data[2]);
        //Change Weapon Level

        Debug.Log("LoadState");
    }
}
