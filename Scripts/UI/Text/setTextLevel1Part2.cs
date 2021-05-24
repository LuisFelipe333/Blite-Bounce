using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setTextLevel1Part2 : MonoBehaviour
{
    public GameObject nextObject;
    bool setObject;
    public int search;
    int i;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
        //Time.timeScale=0;
        setObject=true;
        
    }

    // Update is called once per frame
    void Update()
    {
        joystick.gameObject.SetActive(true);
        if(setObject&&!FinishedParts.finishedParts.parts[search]&&(joystick.Vertical!=0||joystick.Horizontal!=0))
        {
            setObject=false;
            StartCoroutine("WaitForNextText");
        } 
    }

    IEnumerator WaitForNextText()
    {
        yield return new WaitForSeconds(6f);
        
        nextObject.SetActive(true);
    }

}
