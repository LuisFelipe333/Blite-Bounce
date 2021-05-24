using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvDestroyWhite : MonoBehaviour
{   
    public bool bounce;
    public bool itsDestroy;
    public GameObject hearts;
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
            if(other.gameObject.GetComponent<SurvChangeSquares>().black)
            {
                itsDestroy=true;
                Destroy(gameObject);
                
            }

            if(!other.gameObject.GetComponent<SurvChangeSquares>().black)
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
                Debug.Log("primer checkpoint");
            itsDestroy=true;
            other.GetComponent<SurvMonsterSound>().CollisionBalls(this.gameObject);
            Destroy(gameObject);
            }
            else if(other.tag=="Shield")
            {
                itsDestroy=true;
                other.GetComponent<Shields>().CollisionBalls(this.gameObject);
                Destroy(gameObject);
            }
        }

        if(other.tag=="Heart")
        {
            hearts=GameObject.Find("PlayerHearts");
            hearts.GetComponent<SurvLifeHeart>().plusLife(1);
            Destroy(other.gameObject);
        }
                
    }
}