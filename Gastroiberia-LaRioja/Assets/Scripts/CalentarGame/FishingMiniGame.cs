using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FishingMiniGame : MonoBehaviour
{
    //hacer que el pez se mueva
    [Header("Fishing Area")]
    [SerializeField] Transform topBounds;
    [SerializeField] Transform bottomBounds;

    [Header("Fishing Settings")]
    [SerializeField] Transform fish;
    [SerializeField] float smoothMotion = 3f; //suavizar el movimiento del pez
    [SerializeField] float fishTimeRandomizer = 3f; //cada cuanto tiempo se mueve el pez;
    float fishPosition;
    float fishSpeed;
    float fishTimer;
    float fishTargetPosition;

    [Header("Hook Settings")]
    [SerializeField] Transform hook;
    [SerializeField] float hookSize = .18f;
    [SerializeField] float hookSpeed = .1f;
    [SerializeField] float hookGravity = .05f;
    float hookPosition;
    float hookPullVelocity;

    [Header("Progress Bar Settings")]
    [SerializeField] Transform progressBarContainer;
    [SerializeField] float hookPower;
    [SerializeField] float progressBarDecay;
    float catchProgress;

    [SerializeField] GameObject menuPausa;
    [SerializeField] private AudioSource _source;
    public AudioSource aceite;
    public AudioSource subirBarra;

    private void Start()
    {
        catchProgress = .2f;
       
    }
    private void FixedUpdate()
    {
        MoveFish();
        MoveHook();
        CheckProgress();
        
    }

    private void CheckProgress()
    {
        Vector3 progressBarSacle = progressBarContainer.localScale;
        progressBarSacle.y = catchProgress;
        progressBarContainer.localScale = progressBarSacle;


        float min = hookPosition - hookSize / 2;
        float max = hookPosition + hookSize / 2;

        if (min < fishPosition && fishPosition < max)
        {
            catchProgress += hookPower * Time.deltaTime;
            Debug.Log("TOUCH");
            if(!subirBarra.isPlaying){
                subirBarra.Play();
            }
            
            if(catchProgress >= 1)
            {
                
                hookSpeed = 0;
                fishSpeed = 0;
                fishPosition = 0;
                Debug.Log("You WIN");
                menuPausa.SetActive(true);
                _source.Pause();
                aceite.Pause();
                subirBarra.Pause();
               
            }
        }
        else
        {
            subirBarra.Pause();
            catchProgress -= progressBarDecay * Time.deltaTime;
            if(catchProgress <= 0)
            {
                //loose
                Debug.Log("You lost");
            }

        }
        catchProgress = Mathf.Clamp(catchProgress, 0, 1);

    }
    private void MoveHook()
    {
        if (Input.GetMouseButton(0))
        {
            //aumentar pullvelocity
            hookPullVelocity += hookSpeed * Time.deltaTime; //sube el hook

        }
        hookPullVelocity -= hookGravity * Time.deltaTime;
        hookPosition += hookPullVelocity;

        if (hookPosition - hookSize / 2 <= 0 && hookPullVelocity < 0)
        {
            hookPullVelocity = 0;
        }

        if (hookPosition + hookSize / 2 >= 1 && hookPullVelocity > 0)
        {
            hookPullVelocity = 0;
        }


        hookPosition = Mathf.Clamp(hookPosition, hookSize/2, 1 - hookSize/2);
        hook.position = Vector3.Lerp(bottomBounds.position, topBounds.position, hookPosition);
    }

    private void MoveFish()
    {
        //basado en un tiempo, elige una posicion aleatoria
        // mover el pez a esa posicion suavemente
        fishTimer -= Time.deltaTime;
        if (fishTimer < 0)
        {
            //elegir una nueva posicion y reseta el tiempo
            fishTimer = Random.value * fishTimeRandomizer;
            fishTargetPosition = Random.value;

        }
        fishPosition = Mathf.SmoothDamp(fishPosition, fishTargetPosition, ref fishSpeed, smoothMotion);
        fish.position = Vector2.Lerp(bottomBounds.position, topBounds.position, fishPosition);
    }
   
}
