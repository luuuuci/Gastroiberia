using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }
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
    // public weapon weapon...

    //Logic
    public int pesos;
    public int experience;
    public int recetas;

    public bool itemCogido;


    //Save state

    // INT preferedSkin
    // INT pesos
    // INT experience
    // INT weaponLevel
    public void CogerItem()
    {
        itemCogido = true;
        Debug.Log(itemCogido);
    }
    public void SaveState()
    {
        string s = "";

        s += "0" + "|";
        s += pesos.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0";
        s += recetas.ToString() + "|";


        PlayerPrefs.SetString("SaveState", s);




        Debug.Log("SaveState");


    }
    public void LoadState(Scene s, LoadSceneMode mode)
    {
        if (!PlayerPrefs.HasKey("SaveState"))
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        //Change player skin
        //pesos
        pesos = int.Parse(data[1]);
        experience = int.Parse(data[2]);
        recetas = int.Parse(data[3]);
        //change weapon level


        SceneManager.sceneLoaded -= LoadState;
        Debug.Log("LoadState");

    }

}
