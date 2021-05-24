using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplayerMonsterLife : MonoBehaviour
{
    public AudioClip sound;
    public Image imageHearts;
    public bool setActive;
    // Start is called before the first frame update
    void Start()
    {
        setActive=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void CollisionBalls(GameObject other)
    {
        if(setActive)
        {
            if(other.gameObject.tag=="WhiteBall")
            {    
                if(other.gameObject.GetComponent<MultiplayerDestroyWhite>().bounce)    
                    {
                        imageHearts.GetComponent<MultiplayerMonsterHeart>().offLife(1);
                        AudioSource.PlayClipAtPoint(sound,transform.position);
                    }
            }
            else
            {
                if(other.gameObject.tag=="BlackBall")
                {
                    if(other.gameObject.GetComponent<MultiplayerDestroyBlack>().bounce)  
                    {  
                    imageHearts.GetComponent<MultiplayerMonsterHeart>().offLife(1);
                    AudioSource.PlayClipAtPoint(sound,transform.position);
                    }

                }
            } 
        }    
    }
      
}