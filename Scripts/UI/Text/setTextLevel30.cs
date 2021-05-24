using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class setTextLevel30 : MonoBehaviour
{
    public String[] textParts;
    public String[] partesTexto;
    String textoMostrar;
    public GameObject restartButton;
    public GameObject selectionButton;
    public GameObject monster;
    public GameObject camp;
    public GameObject pauseButton;
    public GameObject winText;
    public GameObject sceneCodder;
    public int search;//sirve para buscar en el arreglo
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinishLevel30()
    {
        StartCoroutine("WaitForFinished");
    }

    IEnumerator WaitForFinished()
    {
        int i;
    sceneCodder.GetComponent<WinsControl>().doIt=false;

    
    joystick.gameObject.SetActive(false);
    gameObject.GetComponent<Image>().enabled=true;
    gameObject.transform.GetChild(0).GetComponent<Image>().enabled=true;
    gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text="";

    Debug.Log("colocado false");
        if(Idioma.idioma.idiomaSeleccionado==0)
        {
            for(i=0;i<textParts.Length;i++)//recorremos todas las posiciones del arreglo
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
            
            for(i=0;i<partesTexto.Length;i++)//recorremos todas las posiciones del arreglo
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
        Debug.Log(FinishedParts.finishedParts.parts[search]);

        DatosSkins.datosSkins.skinConseguida=0;
        DatosSkins.datosSkins.skinSeleccionada=0;
        DatosSkins.datosSkins.GuardarListaSkins();

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Credits");

        yield return new WaitForSeconds(4f);
        restartButton.SetActive(true);
        selectionButton.SetActive(true);
        

    }
}
