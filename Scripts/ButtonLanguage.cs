    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLanguage : MonoBehaviour
{
    public Sprite Ingles;
    public Sprite Español;
    // Start is called before the first frame update
    void Start()
    {
        if(Idioma.idioma.idiomaSeleccionado==0)
            gameObject.GetComponent<Image>().sprite=Ingles;
        else if(Idioma.idioma.idiomaSeleccionado==1)
            gameObject.GetComponent<Image>().sprite=Español;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
