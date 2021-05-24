using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

            if(transform.position.y<2.7&&joystick.Vertical>0)
            transform.Translate(new Vector3(0f,joystick.Vertical*7f,0f)*Time.deltaTime);

            if(transform.position.y>0.30&&joystick.Vertical<0)
            transform.Translate(new Vector3(0f,joystick.Vertical*7f,0f)*Time.deltaTime);


        
    




    }
}
