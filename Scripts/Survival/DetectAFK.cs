using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAFK : MonoBehaviour
{
    public float timeAFK;
    public bool setActive;
    public GameObject screenAFK;
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        timeAFK=0;
        setActive=true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(setActive)
        {
            
            if(joystick.Vertical==0&&joystick.Horizontal==0)
            timeAFK+=Time.deltaTime;

            if(joystick.Vertical!=0||joystick.Vertical!=0)
            timeAFK=0;

            if(timeAFK>20)
            {
                screenAFK.SetActive(true);
                gameObject.GetComponent<SurvWinsControl>().StopEverything();
                setActive=false;
            }

        }

    }
}
