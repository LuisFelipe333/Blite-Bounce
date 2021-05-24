using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvWinsControl : MonoBehaviour
{
    public GameObject GameOverText;
    public GameObject ImageStar;
    public Text textEstrellas;
    public int estrellasGanadas=0;
    public float[] porcentajeEstrellas=new float[50];
    //bool youWon;
    public GameObject camp;
    public GameObject monster;
    public GameObject RestartButton;
    public GameObject MenuButton;
    public GameObject generalCodder;
    public GameObject pauseButton;
    public GameObject doubleButton;
    public Text scoreText;

    int aux;
    bool lose;
    int star;
    
    // Start is called before the first frame update
    void Start()
    {
        //youWon=false;
        generalCodder=GameObject.Find("Scripter");
        lose=false;
        star=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!lose)//mientras no hayas perdido
        {
            if(porcentajeEstrellas[star]<50)    //aumente la casilla hasta llegar a 50 
            {
                porcentajeEstrellas[star]+=Time.deltaTime;  
            }
            else
            {
                star++;    //cambia de casilla ya que la otra ya llego a 50
            }
        }
    }

    public void CheckWin(bool victory)
    {
        lose=true;
        StopEverything();
        
        for(int i=0;i<star+1;i++)
        {
            aux=Random.Range(0,100);
            if(aux<porcentajeEstrellas[i])
            estrellasGanadas++;
        }    
            
        GameOverText.SetActive(true);
        textEstrellas.gameObject.SetActive(true);
        ImageStar.SetActive(true);
        textEstrellas.text="x"+estrellasGanadas;
        StartCoroutine("WaitForStars");
        
        StartCoroutine("PauseButtons");
        
        if(scoreText.GetComponent<SumarPuntuacion>().puntaje>RecordSurvival.recordSurvival.record)
        {
            RecordSurvival.recordSurvival.record=scoreText.GetComponent<SumarPuntuacion>().puntaje;
            RecordSurvival.recordSurvival.GuardarRecord();
        }
        
    }

    public void StopEverything()
    {
        camp.GetComponent<SurvLessLife>().setActive=false;
        monster.GetComponent<ShootEspecialBall>().setActive=false;
        monster.GetComponent<CrearCorazones>().setActive=false;
        monster.GetComponent<Shoot>().setActive=false;
        scoreText.GetComponent<SumarPuntuacion>().setActive=false;
        pauseButton.SetActive(false);
        this.gameObject.GetComponent<DetectAFK>().enabled=false;
    }


    IEnumerator PauseButtons()
    {
        yield return new WaitForSeconds(3);
        RestartButton.SetActive(true);
        MenuButton.SetActive(true);
        doubleButton.SetActive(true);
    }

    IEnumerator WaitForStars()
    {
        yield return new WaitForSeconds(3);
        EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+estrellasGanadas;
    }



}
