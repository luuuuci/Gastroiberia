using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject ensenarCaparrones;

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
    //public Player player;
    // public weapon weapon...

    //Logic
    public int pesos;
   // public int experience;
    //public int recetas;

    public bool itemCogido;

    
   
    public void Display(){
        
        
    }
    public void Hide(){
        ensenarCaparrones.SetActive(false);
    }
    void Update(){
       // Debug.Log(pesos);
       if(pesos >= 1){

            Debug.Log("DESCBLOQUEADO");
            ensenarCaparrones.SetActive(true);
        } else {
            ensenarCaparrones.SetActive(false);
        }
    }
    public void CogerItem()
    {
        itemCogido = true;
        Debug.Log(itemCogido);
    }
    public void grantPesos(){
        pesos++;
    }
    public void SaveState()
    {
        string s = "";

       // s += "0" + "|";
        s += pesos.ToString() + "|";
      //  s += experience.ToString() + "|";
      //  s += "0";
      //  s += recetas.ToString() + "|";


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
        pesos = int.Parse(data[0]);
       // experience = int.Parse(data[2]);
        //recetas = int.Parse(data[3]);
        //change weapon level


        SceneManager.sceneLoaded -= LoadState;
        Debug.Log("LoadState");

    }
    public void Pausar(){
        Time.timeScale = 0f;
    }
    public void Continuar(){
        Time.timeScale = 1f;
    }

}
