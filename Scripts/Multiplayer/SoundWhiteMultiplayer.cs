﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWhiteMultiplayer : MonoBehaviour
{
    public AudioClip bounceSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Cuadro")
        {

            if(!other.gameObject.GetComponent<ChangeSquareMultiplayer>().black)
            AudioSource.PlayClipAtPoint(bounceSound,transform.position);
        } 

        
            
    }
}