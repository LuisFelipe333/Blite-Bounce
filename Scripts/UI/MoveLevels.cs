using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLevels : MonoBehaviour
{
    public Joystick joystick;
    public bool up,down;
    // Start is called before the first frame update
    void Start()
    {
        up=false;
        down=false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //if(transform.position.y<yMax&&joystick.Vertical>0)
        if(!up&&joystick.Vertical>0)
            transform.Translate(new Vector3(0f,joystick.Vertical*1500f,0f)*Time.deltaTime);

        //if(transform.position.y>yMin&&joystick.Vertical<0)
        if(!down&&joystick.Vertical<0)
            transform.Translate(new Vector3(0f,joystick.Vertical*1500f,0f)*Time.deltaTime);
            
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Exit");
        if(other.tag=="LimiteSuperior")
            up=true;
        if(other.tag=="LimiteInferior")
            down=true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Exit");
        if(other.tag=="LimiteSuperior")
            up=false;
        if(other.tag=="LimiteInferior")
            down=false;
    }

     
    
}
