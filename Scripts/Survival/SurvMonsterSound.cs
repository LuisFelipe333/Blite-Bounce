using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvMonsterSound : MonoBehaviour
{
    public AudioClip sound;
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
        
        Debug.Log("Sengundo");
            if(other.gameObject.tag=="WhiteBall")
            {    
                Debug.Log("tercero");
                if(other.gameObject.GetComponent<SurvDestroyWhite>().bounce)
                {    
                    Debug.Log("cuarto");
                    AudioSource.PlayClipAtPoint(sound,transform.position);
                }
            }
            else
            {
                if(other.gameObject.tag=="BlackBall")
                {
                    Debug.Log("tercero");
                    if(other.gameObject.GetComponent<BlSurvDestroy>().bounce)
                    {    Debug.Log("cuarto");
                    AudioSource.PlayClipAtPoint(sound,transform.position);
                    }

                }
            }   
    }
}
