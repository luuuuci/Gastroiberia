using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour
{
    private const string SAVE_SEPARATOR = "#SAVE-VALUE#";
    public int recetasAmounta;
    public TextMeshProUGUI text;
    public GameObject gridCollision0;
    public GameObject gridCollision1;
    public GameObject gridCollision2;
    public GameObject gridCollision3;
    public GameObject gridCollision4;
    public GameObject gridCollision5;
    public GameObject gridCollision6;
    public GameObject gridCollision7;
    public GameObject gridCollision8;

     public GameObject caparrones;


    
    // Start is called before the first frame update
    void Awake()
    {
        SaveObject saveObject = new SaveObject {
            recetasAmount = 5,
        };
        string json = JsonUtility.ToJson(saveObject);
        Debug.Log(json);

        SaveObject loadedSaveObject = JsonUtility.FromJson<SaveObject>(json);
        Debug.Log(loadedSaveObject.recetasAmount);
       // DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = recetasAmounta.ToString();
        

        if(recetasAmounta == 0){
            gridCollision0.SetActive(true);
            caparrones.SetActive(false);
            
        }
        if(recetasAmounta ==1){
            gridCollision0.SetActive(false);
            gridCollision1.SetActive(true);
            caparrones.SetActive(true);
            
        }
        if(recetasAmounta ==2){
            gridCollision1.SetActive(false);
            gridCollision2.SetActive(true);
            
        }
        if(recetasAmounta ==3){
            gridCollision2.SetActive(false);
            gridCollision3.SetActive(true);
            
        }
        if(recetasAmounta ==4){
            gridCollision3.SetActive(false);
            gridCollision4.SetActive(true);
            
        }
        if(recetasAmounta ==5){
            gridCollision4.SetActive(false);
            gridCollision5.SetActive(true);
        }
        if(recetasAmounta ==6){
            gridCollision5.SetActive(false);
            gridCollision6.SetActive(true);
            
        }
        if(recetasAmounta ==7){
            gridCollision6.SetActive(false);
            gridCollision7.SetActive(true);
           
        }
        if(recetasAmounta ==8){
            gridCollision7.SetActive(false);
            gridCollision8.SetActive(true);
            
        }
        if(recetasAmounta ==9){
            gridCollision8.SetActive(false);
            
        }
       
    }
    public void grantReceta(){
        recetasAmounta++;
    }
    public void Save(){
        int recetasAmount = recetasAmounta;

        SaveObject saveObject = new SaveObject {
            recetasAmount = recetasAmount
        };

        string json = JsonUtility.ToJson(saveObject);

        File.WriteAllText(Application.dataPath + "/save.txt", json);
        Debug.Log("SAVED");

        //CMDebug.TextPopupMouse("Saved");


    }
    public void Load(){
        if (File.Exists(Application.dataPath + "/save.txt")){
            string saveString = File.ReadAllText(Application.dataPath + "/save.txt");
            //CMDebug.TextPopupMouse("Loaded: " + saveString);
            Debug.Log("LOADED");

            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            recetasAmounta = saveObject.recetasAmount;
            

        } else {
            
            //CMDebug.TextPopupMouse("No save");
        }
    }

    private class SaveObject {
        public int recetasAmount;
    }
}
