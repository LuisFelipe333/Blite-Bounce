using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LessLife : MonoBehaviour
{
    public Image playerHearts;
    public bool setActive;
    GameObject stars;
    // Start is called before the first frame update
    void Start()
    {
        setActive=true;
        stars=GameObject.Find("CodderForScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if(setActive){
            if(other.tag=="WhiteBall")
            {        
                if(!other.GetComponent<DestroyWhite>().itsDestroy)
                {           
                Destroy(other.gameObject);
                playerHearts.GetComponent<LifeHeart>().offLife(1);       
                stars.GetComponent<LevelStars>().puntosPerdidos++;        
                }
            }
            else
            {
                if(other.tag=="BlackBall")
                {
                    if(!other.GetComponent<DestroyBlack>().itsDestroy)  
                    {  
                        playerHearts.GetComponent<LifeHeart>().offLife(1);
                        Destroy(other.gameObject);
                        stars.GetComponent<LevelStars>().puntosPerdidos++;
                    }
                }
            }
        }

    }

}
