using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerShield : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollisionBalls(GameObject other)
    {
        
            if(other.gameObject.tag=="WhiteBall")
            {    
                if(other.gameObject.GetComponent<MultiplayerDestroyWhite>().bounce)    
                    Destroy(gameObject);
            }
            else
            {
                if(other.gameObject.tag=="BlackBall")
                {
                    if(other.gameObject.GetComponent<MultiplayerDestroyBlack>().bounce)    
                    Destroy(gameObject);

                }
            } 
          
    }
}

