using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("WaitForNextScene");
    }

    IEnumerator WaitForNextScene()
    {
        yield return new WaitForSeconds(3);


        if(Idioma.idioma.idiomaSeleccionado==0||Idioma.idioma.idiomaSeleccionado==1)
        SceneManager.LoadScene("Menu");
        else
        SceneManager.LoadScene("LanguageScreen");
        
    }
}
