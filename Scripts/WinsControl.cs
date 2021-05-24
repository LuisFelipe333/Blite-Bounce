using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinsControl : MonoBehaviour
{
    public GameObject winText;
    public GameObject loseText;
    //bool youWon;
    public GameObject camp;
    public GameObject monster;
    public GameObject RestartButton;
    public GameObject MenuButton;
    public GameObject NextLevelButton;
    public GameObject generalCodder;
    public GameObject pauseButton;
    bool checkIt;
    public bool doIt;

    // Start is called before the first frame update
    void Start()
    {
        //youWon=false;
        generalCodder=GameObject.Find("Scripter");
        checkIt=false;
        doIt=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckWin(bool victory)
    {
        if(!checkIt)
        {
            checkIt=true;
        camp.GetComponent<LessLife>().setActive=false;
        monster.GetComponent<MonsterLife>().setActive=false;
        monster.GetComponent<Shoot>().setActive=false;
        pauseButton.SetActive(false);
            if(victory)
            {
            winText.SetActive(true);
            StartCoroutine("WaitForStars");
            }
        else
        {
        loseText.SetActive(true);
        }        

        
        StartCoroutine("PauseButtons");
        }
        
    }

    IEnumerator PauseButtons()
    {
        yield return new WaitForSeconds(3);
        if(doIt)
        {
        RestartButton.SetActive(true);
        MenuButton.SetActive(true);
            if(EstrellasPorNivel.estrellasPorNivel.getStars(NextLevelButton.GetComponent<GoToLevel>().nivel-1)>0)
            NextLevelButton.SetActive(true);
        }
    }

    IEnumerator WaitForStars()
    {
        Debug.Log("Si entro");
        yield return new WaitForSeconds(3);
        this.GetComponent<LevelStars>().getStars();
        Debug.Log("Si lo hizo");
    }



}
