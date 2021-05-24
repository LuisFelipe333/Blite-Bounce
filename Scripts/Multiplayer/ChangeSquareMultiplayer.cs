using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSquareMultiplayer : MonoBehaviour
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

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag=="WhiteBall"&&black)
        {
        gameObject.SetActive(false);
        stars.GetComponent<LevelMultiplayerStars>().puntosPerdidos++;
        }
        else
            if(other.gameObject.tag=="BlackBall"&&!black)
            {
            gameObject.SetActive(false);
            stars.GetComponent<LevelMultiplayerStars>().puntosPerdidos++;
            }
    }

}