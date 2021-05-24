using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonLenguajeText : MonoBehaviour
{
     public String Ingles;
    public String Español;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.GetComponent<Button>()!=null)
        {
            if(Idioma.idioma.idiomaSeleccionado==0)
                gameObject.GetComponentInChildren<Text>().text=Ingles;
            else if(Idioma.idioma.idiomaSeleccionado==1)
                gameObject.GetComponentInChildren<Text>().text=Español;
        }

        if(gameObject.GetComponent<Text>()!=null)
        {
            
            if(Idioma.idioma.idiomaSeleccionado==0)
                gameObject.GetComponent<Text>().text=Ingles;
            else if(Idioma.idioma.idiomaSeleccionado==1)
                gameObject.GetComponent<Text>().text=Español;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recharge()
    {
        if(gameObject.GetComponent<Button>()!=null)
        {
            if(Idioma.idioma.idiomaSeleccionado==0)
                gameObject.GetComponentInChildren<Text>().text=Ingles;
            else if(Idioma.idioma.idiomaSeleccionado==1)
                gameObject.GetComponentInChildren<Text>().text=Español;
        }

        if(gameObject.GetComponent<Text>()!=null)
        {
            if(Idioma.idioma.idiomaSeleccionado==0)
                gameObject.GetComponent<Text>().text=Ingles;
            else if(Idioma.idioma.idiomaSeleccionado==1)
                gameObject.GetComponent<Text>().text=Español;
        }

    }

}
