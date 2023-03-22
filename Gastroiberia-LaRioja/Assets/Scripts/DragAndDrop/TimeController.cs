using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;
    [SerializeField] GameObject menuPerder;

    private float restante;
    public bool enMarcha;

    // Start is called before the first frame update
    void Start()
    {
        restante = (min * 60) + seg;
        enMarcha = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;
            if(restante < 1)
            {
                enMarcha = false;
                Time.timeScale = 0f;
                menuPerder.SetActive(true);

            }
        }
        int tempMin = Mathf.FloorToInt(restante / 60);
        int tempSeg = Mathf.FloorToInt(restante % 60);
        tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
    }
}
