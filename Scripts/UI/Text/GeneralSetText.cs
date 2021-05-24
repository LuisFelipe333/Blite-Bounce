using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralSetText : MonoBehaviour
{
    public String[] textParts;
    public String[] partesTexto;
    String textoMostrar;
    //public GameObject objectText;
    bool setText;
    public int search;
    public GameObject Monster;
    int i;
    public GameObject joystick;
    // Start is called before the first frame update
    /* 
    0=nivel 1
    1=nivel 1 multiplayer
    2=survival
    3=nivel 5(Escudos)
    4=ultimo nivel
    */
    void Start()
    {
        Debug.Log(FinishedParts.finishedParts.parts[search]);
        if(!FinishedParts.finishedParts.parts[search])
        {
        //objectText.GetComponent<setTextLevel1Part2>().enabled=false;
        setText=true;
        Monster.GetComponent<Shoot>().enabled=false;
        joystick.SetActive(false);
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
            for(i=0;i<textParts.Length;i++)//recorremos todas las posiciones del arreglo
            {
                textoMostrar="";
                
                for(int j=0;j<textParts[i].Length;j++)//recorremos cada letra del String
                {
                    
                textoMostrar=string.Concat(textoMostrar,textParts[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.2f);
                }
                yield return new WaitForSeconds(4f);
            }
        }
        else
        {
            
            for(i=0;i<partesTexto.Length;i++)//recorremos todas las posiciones del arreglo
            {
                textoMostrar="";
                
                for(int j=0;j<partesTexto[i].Length;j++)//recorremos cada letra del String
                {
                    
                textoMostrar=string.Concat(textoMostrar,partesTexto[i][j]);
                gameObject.transform.GetChild(0).GetComponentInChildren<Text>().text=textoMostrar;
                Debug.Log(i+"paso"+j);
                yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }
        }
       
        Monster.GetComponent<Shoot>().enabled=true;
        joystick.SetActive(true);
        FinishedParts.finishedParts.parts[search]=true;
        FinishedParts.finishedParts.GuardarPartes();
        //objectText.GetComponent<setTextLevel1Part2>().enabled=true;
        gameObject.SetActive(false);

    }

}
