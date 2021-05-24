using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCorazones : MonoBehaviour
{
    public float timePerShoot;
    public float time;
    public GameObject heart;
    public float speedBall;
    public bool setActive;
    // Start is called before the first frame update
    void Start()
    {   
        timePerShoot=Random.Range(40,70);
        time=0;
        setActive=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(setActive)
        {
            time=time+Time.deltaTime;
            if(time>timePerShoot)
            {             
                switch(Random.Range(1,8))
                {
                case 1:
                Instantiate(heart, new Vector3(1.5f,0,0), Quaternion.identity);
                    break;
                case 2:
                Instantiate(heart, new Vector3(1.5f,1.5f,0), Quaternion.identity);
                    break;
                case 3:
                Instantiate(heart, new Vector3(1.5f,3,0), Quaternion.identity);
                    break;
                case 4:
                Instantiate(heart, new Vector3(0,0,0), Quaternion.identity);
                    break;
                case 5:
                Instantiate(heart, new Vector3(0,3,0), Quaternion.identity);
                    break;
                case 6:
                Instantiate(heart, new Vector3(-1.5f,0,0), Quaternion.identity);
                    break;
                case 7:
                Instantiate(heart, new Vector3(-1.5f,1.5f,0), Quaternion.identity);
                    break;
                case 8:
                Instantiate(heart, new Vector3(-1.5f,3,0), Quaternion.identity);
                    break;
                }
                
                
                timePerShoot=Random.Range(30,50);
                time=0;
            }

        }
    }
}