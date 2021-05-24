using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinsControlMultiplayer : MonoBehaviour
{
    public GameObject winText;
    public GameObject loseText;
    //bool youWon;
    public GameObject camp;
    public GameObject monster;
    public GameObject RestartButton;
    public GameObject MenuButton;
    public GameObject generalCodder;
    public GameObject pauseButton;
    public GameObject NextLevelButton;
    bool checkIt;

    // Start is called before the first frame update
    void Start()
    {
        //youWon=false;
        generalCodder=GameObject.Find("Scripter");
        checkIt=false;
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
            camp.GetComponent<MultiplayerLessLife>().setActive=false;
            monster.GetComponent<MultiplayerMonsterLife>().setActive=false;
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
        RestartButton.SetActive(true);
        MenuButton.SetActive(true);
        if(EstrellasMultiplayer.estrellasMultiplayer.getStars(NextLevelButton.GetComponent<GoToLevel>().nivel-1)>0)
            NextLevelButton.SetActive(true);
    }

    IEnumerator WaitForStars()
    {
        yield return new WaitForSeconds(3);
        this.GetComponent<LevelMultiplayerStars>().getStars();
    }



}
