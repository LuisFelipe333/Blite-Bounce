using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class TextLanguage : MonoBehaviour
{
    public String Ingles;
    public String Español;
    // Start is called before the first frame update
    void Start()
    {
        if(Idioma.idioma.idiomaSeleccionado==0)
            gameObject.GetComponent<Text>().text=System.Text.RegularExpressions.Regex.Unescape(Ingles);
        else if(Idioma.idioma.idiomaSeleccionado==1)
            gameObject.GetComponent<Text>().text=System.Text.RegularExpressions.Regex.Unescape(Español);
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
