using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setTextLevel1 : MonoBehaviour
{
    public String[] textParts;
    public String[] partesTexto;
    String textoMostrar;
    public GameObject restartButton;
    public GameObject selectionButton;
    public GameObject NextLevelButton;
    public GameObject monster;
    public GameObject camp;
    public GameObject pauseButton;
    public GameObject winText;
    public GameObject sceneCodder;
    //public GameObject objectText;
    bool setText;
    public int search;
    public GameObject Monster;
    int i;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FinishedParts.finishedParts.parts[search]);

        if(!FinishedParts.finishedParts.parts[search])
        {
        //objectText.GetComponent<setTextLevel1Part2>().enabled=false;
        setText=true;
        Monster.GetComponent<Shoot>().enabled=false;
        joystick.gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(false);
            setText=false;
        }
        //Time.timeScale=0;

    }

    // Update is called once per frame
    void Update()
    {
        if(setText)
        {
            setText=false;
            StartCoroutine("WaitForNextText");
            
        }
        

        
    }

    IEnumerator WaitForNextText()
    {
        if(Idioma.idioma.idiomaSeleccionado==0)
        {
            for(i=0;i<6;i++)//recorremos todas las posiciones del arreglo
            {
                
                textoMostrar="";
                for(int j=0;j<textParts[i].Length;j++)//recorremos cada letra del arreglo
                {
                textoMostrar=string.Concat(textoMostrar,textParts[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }
            //objectText.GetComponent<setTextLevel1Part2>().enabled=true;
            gameObject.GetComponent<Image>().enabled=false;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=false;
            joystick.gameObject.SetActive(true);
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";

            //colo continua hasta que mueven el joystick
            yield return new WaitWhile(()=> joystick.Vertical==0&&joystick.Horizontal==0);
            yield return new WaitForSeconds(5f);

            joystick.gameObject.SetActive(false);
            gameObject.GetComponent<Image>().enabled=true;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=true;
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";
            


            for(i=6;i<10;i++)//recorremos todas las posiciones del arreglo
            {
                
                textoMostrar="";

                for(int j=0;j<textParts[i].Length;j++)//recorremos cada letra del arreglo
                {
                textoMostrar=string.Concat(textoMostrar,textParts[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }

            gameObject.GetComponent<Image>().enabled=false;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=false;
            joystick.gameObject.SetActive(true);
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";

            //colo continua hasta que mueven el joystick
            yield return new WaitWhile(()=> joystick.Vertical==0&&joystick.Horizontal==0);
            yield return new WaitForSeconds(5f);

            joystick.gameObject.SetActive(false);
            gameObject.GetComponent<Image>().enabled=true;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=true;
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";

            for(i=10;i<18;i++)//recorremos todas las posiciones del arreglo
            {
                
                textoMostrar="";

                for(int j=0;j<textParts[i].Length;j++)//recorremos cada letra del arreglo
                {
                textoMostrar=string.Concat(textoMostrar,textParts[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }

            gameObject.GetComponent<Image>().enabled=false;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=false;
            joystick.gameObject.SetActive(true);
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";
            
        }
        else
        {
            for(i=0;i<6;i++)//recorremos todas las posiciones del arreglo
            {
                
                textoMostrar="";
                for(int j=0;j<partesTexto[i].Length;j++)//recorremos cada letra del arreglo
                {
                textoMostrar=string.Concat(textoMostrar,partesTexto[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }
            //objectText.GetComponent<setTextLevel1Part2>().enabled=true;
            gameObject.GetComponent<Image>().enabled=false;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=false;
            joystick.gameObject.SetActive(true);
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";

            //colo continua hasta que mueven el joystick
            yield return new WaitWhile(()=> joystick.Vertical==0&&joystick.Horizontal==0);
            yield return new WaitForSeconds(5f);

            joystick.gameObject.SetActive(false);
            gameObject.GetComponent<Image>().enabled=true;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=true;
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";
            


            for(i=6;i<10;i++)//recorremos todas las posiciones del arreglo
            {
                
                textoMostrar="";

                for(int j=0;j<partesTexto[i].Length;j++)//recorremos cada letra del arreglo
                {
                textoMostrar=string.Concat(textoMostrar,partesTexto[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }

            gameObject.GetComponent<Image>().enabled=false;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=false;
            joystick.gameObject.SetActive(true);
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";

            //colo continua hasta que mueven el joystick
            yield return new WaitWhile(()=> joystick.Vertical==0&&joystick.Horizontal==0);
            yield return new WaitForSeconds(5f);

            joystick.gameObject.SetActive(false);
            gameObject.GetComponent<Image>().enabled=true;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=true;
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";

            for(i=10;i<18;i++)//recorremos todas las posiciones del arreglo
            {
                
                textoMostrar="";

                for(int j=0;j<partesTexto[i].Length;j++)//recorremos cada letra del arreglo
                {
                textoMostrar=string.Concat(textoMostrar,partesTexto[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }

            gameObject.GetComponent<Image>().enabled=false;
            gameObject.transform.GetChild(0).GetComponent<Image>().enabled=false;
            joystick.gameObject.SetActive(true);
            gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";
            
        }

        Monster.GetComponent<Shoot>().enabled=true;
        //gameObject.SetActive(false);
    }


    public void FinishedFirstLevel()
    {
        StartCoroutine("WaitForFinished");
    }

    IEnumerator WaitForFinished()
    {
        
    sceneCodder.GetComponent<WinsControl>().doIt=false;

    
    joystick.gameObject.SetActive(false);
    gameObject.GetComponent<Image>().enabled=true;
    gameObject.transform.GetChild(0).GetComponent<Image>().enabled=true;
    gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";

    Debug.Log("colocado false");
        if(Idioma.idioma.idiomaSeleccionado==0)
        {
            for(i=18;i<21;i++)//recorremos todas las posiciones del arreglo
            {
                    
                textoMostrar="";
                for(int j=0;j<textParts[i].Length;j++)//recorremos cada letra del arreglo
                {
                textoMostrar=string.Concat(textoMostrar,textParts[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                
                yield return new WaitForSeconds(0.02f);

                }
                yield return new WaitForSeconds(4f);
            }
        }
        else{
            
            for(i=18;i<21;i++)//recorremos todas las posiciones del arreglo
            {
                    
                textoMostrar="";
                for(int j=0;j<partesTexto[i].Length;j++)//recorremos cada letra del arreglo
                {
                textoMostrar=string.Concat(textoMostrar,partesTexto[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                //Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.02f);
                
                }
                yield return new WaitForSeconds(4f);
            }
        }

        gameObject.GetComponent<Image>().enabled=false;
        Debug.Log("Imagen quitada");
        gameObject.transform.GetChild(0).GetComponent<Image>().enabled=false;
        Debug.Log("Globo quitado");
        joystick.gameObject.SetActive(true);
        gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";
        Debug.Log("Texto quitado");

        FinishedParts.finishedParts.parts[search]=true;
        FinishedParts.finishedParts.GuardarPartes();
        Debug.Log("Parte terminadas");
        EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+10;
        EstadoJuego.estadoJuego.GuardarEstrellas();
        Debug.Log("Dinero!");

        Debug.Log(FinishedParts.finishedParts.parts[search]);
        yield return new WaitForSeconds(4f);
        restartButton.SetActive(true);
        selectionButton.SetActive(true);
        NextLevelButton.SetActive(true);

    }

}


