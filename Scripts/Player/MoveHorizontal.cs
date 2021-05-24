using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
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
        //if(transform.position.x<1.9&&transform.position.x>-1.9)
        //{
        /*if(Input.GetKey("left"))
            transform.Translate(new Vector3(0f,speed,0f)*Time.deltaTime);

        if(Input.GetKey("right"))
            transform.Translate(new Vector3(0f,-speed,0f)*Time.deltaTime);
        */
        if(transform.position.x<1.6&&joystick.Horizontal>0)
            transform.Translate(new Vector3(0f,joystick.Horizontal*7f,0f)*Time.deltaTime);

            if(transform.position.x>-1.6&&joystick.Horizontal<0)
            transform.Translate(new Vector3(0f,joystick.Horizontal*7f,0f)*Time.deltaTime);

        //}
  
    }
}
