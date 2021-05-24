using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHome : MonoBehaviour
{
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void goToHome()
    {
        SoundsController.soundsController.playButtonSound(); 
        SceneManager.LoadScene("Menu");
        Time.timeScale=1;
    }
}
