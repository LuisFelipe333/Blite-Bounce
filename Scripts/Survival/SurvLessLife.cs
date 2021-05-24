using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SurvLessLife : MonoBehaviour
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
                if(!other.GetComponent<SurvDestroyWhite>().itsDestroy)
                {           
                Destroy(other.gameObject);
                playerHearts.GetComponent<SurvLifeHeart>().offLife(1);             
                }
            }
            else
            {
                if(other.tag=="BlackBall")
                {
                    if(!other.GetComponent<BlSurvDestroy>().itsDestroy)  
                    {  
                        playerHearts.GetComponent<SurvLifeHeart>().offLife(1);
                        Destroy(other.gameObject);
                    }
                }
            }
        }

        if(other.tag=="EspecialBall")
        Destroy(other.gameObject);

    }

}