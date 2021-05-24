using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
public class SaveWin : MonoBehaviour
{
    public bool isWin;
    public GameObject prueba;
    // Start is called before the first frame update
    void Start()
    {
        isWin=false;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        prueba=GameObject.Find("Text");
        if(SceneManager.GetActiveScene().name=="Menu"&&isWin)
        {
            prueba.GetComponent<Text>().text="pitoCosmico";
        }
    }
}

