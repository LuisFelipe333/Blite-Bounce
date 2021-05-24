using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject MenuButton;
    public Transform image;
    // Start is called before the first frame update
    void Start()
    {
       image=gameObject.transform.GetChild(0);
       image.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PauseGame()
    {
        if(Time.timeScale==0)
        {
        Time.timeScale=1;
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);
        image.gameObject.SetActive(false);
        }
        else
        {
            if(Time.timeScale==1)
            {
            Time.timeScale=0;
            RestartButton.SetActive(true);
            MenuButton.SetActive(true);
            image.gameObject.SetActive(true);
            //PlayButton.SetActive(true);
            }
        }
    }
}
