using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SumarPuntuacion : MonoBehaviour
{
    public float puntaje;
    Text scoreText;
    public bool setActive;
    // Start is called before the first frame update
    void Start()
    {
        scoreText=gameObject.GetComponent<Text>();
        setActive=true;
        puntaje=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(setActive)
        {
        puntaje+=Time.deltaTime;
        scoreText.text=puntaje.ToString("N1");
        }
    }
}
