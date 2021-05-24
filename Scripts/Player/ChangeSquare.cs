using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSquare : MonoBehaviour
{
    public bool black;
    GameObject stars;
    // Start is called before the first frame update
    void Start()
    {
        black=false;
        stars=GameObject.Find("CodderForScene");
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyUp("space")&&!black)
        {
            gameObject.GetComponent<Animator>().SetBool("black",true);
            black=true;
        }
        else
        {
            if(Input.GetKeyUp("space")&&black)
            {
            gameObject.GetComponent<Animator>().SetBool("black",false);
            black=false;
            }
        }
        */
        

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag=="WhiteBall"&&black)
        {
        gameObject.SetActive(false);
        stars.GetComponent<LevelStars>().puntosPerdidos++;
        }
        else
            if(other.gameObject.tag=="BlackBall"&&!black)
            {
            gameObject.SetActive(false);
            stars.GetComponent<LevelStars>().puntosPerdidos++;
            }
    }

}
