using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{
    public int idioma;
    public GameObject creditsButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Language()
    {
        Idioma.idioma.GuardarIdioma(idioma); //0 = ingles, 1=español  
        if(creditsButton!=null)
        creditsButton.GetComponent<ButtonLenguajeText>().recharge(); 
    }
}
