using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhite : MonoBehaviour
{   
    public bool bounce;
    public bool itsDestroy;
    // Start is called before the first frame update
    void Start()
    {
        bounce=false;
        itsDestroy=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Cuadro")
        {
            if(other.gameObject.GetComponent<ChangeSquare>().black)
            {
                itsDestroy=true;
                Destroy(gameObject);
                
            }

            if(!other.gameObject.GetComponent<ChangeSquare>().black)
            {
                    
                bounce=true;  
            }
        } 

        if(other.gameObject.tag=="WhiteBall"||other.gameObject.tag=="BlackBall")
        {
            itsDestroy=true;
            Destroy(gameObject);
        }
                    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(bounce)
        {
            if(other.tag=="Monster")
            {
            itsDestroy=true;
            other.GetComponent<MonsterLife>().CollisionBalls(this.gameObject);
            Destroy(gameObject);
            }
            else if(other.tag=="Shield")
            {
                itsDestroy=true;
                other.GetComponent<Shields>().CollisionBalls(this.gameObject);
                Destroy(gameObject);
            }
        }
                
    }
}
