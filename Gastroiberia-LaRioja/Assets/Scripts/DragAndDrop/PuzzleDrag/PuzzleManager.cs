using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    
    [SerializeField] private List<PuzzleSlot> _slotPrefabs;
    [SerializeField] private PuzzlePiece _piecePrefab;
    [SerializeField] private Transform _slotParent, _pieceParent;
    [SerializeField] GameObject menuPausa;
    [SerializeField] GameObject panelTiempo;
    [SerializeField] public AudioSource _source;
    public RasilloDragAndDrop rasillo;
    
    
   // public AnguianoDragAndDrop anguiano;


    

    public int contador;

    void Start()
    {
        contador = 0;
        Spawn();
        
        
    }
    

    void Update()
    {
        
         if (rasillo.estaEscena == 0){
            Debug.Log("funciona");
            if(contador == 7){
                
            _source.Pause();
            menuPausa.SetActive(true);
            panelTiempo.SetActive(false);
            
            }
         } else 

       if (contador == 10)
        {
           Debug.Log("GANASTE");
            _source.Pause();
            menuPausa.SetActive(true);
            panelTiempo.SetActive(false);
            
            

        }
    }
    void Spawn()
    {
        var randomSet = _slotPrefabs.OrderBy(s => Random.value).Take(10).ToList();

        for(int i = 0; i < randomSet.Count; i++)
        {
            var spawnedSlot = Instantiate(randomSet[i], _slotParent.GetChild(i).position, Quaternion.identity);
            var spawnedPiece = Instantiate(_piecePrefab, _pieceParent.GetChild(i).position, Quaternion.identity);
            spawnedPiece.Init(spawnedSlot);
        }

    }
}
