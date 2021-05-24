using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GoToLevel : MonoBehaviour
{
    public String nameScene;
    public int nivel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToLevel()
    {
        Debug.Log("pito cosmico");
        SoundsController.soundsController.playButtonSound(); 

        if(!((!nameScene.Contains("LevelSelection")&&!nameScene.Contains("LevelMultiplayerSelection"))&&(nameScene.Contains("Level")||nameScene.Contains("Multiplayer")||nameScene.Contains("Survival"))))
        SoundsController.soundsController.changeToMenuSong();

        if((!nameScene.Contains("LevelSelection")&&!nameScene.Contains("LevelMultiplayerSelection"))&&(nameScene.Contains("Level")||nameScene.Contains("Multiplayer")||nameScene.Contains("Survival")))
        SoundsController.soundsController.changeToMatchSong();

        


        SceneManager.LoadScene(nameScene);
        Time.timeScale=1;
    //Debug.Log("Hasta aqui si");
    //AdministrarEscenas.administrarEscenas.escenaActual=nameScene;
            
    }
}
