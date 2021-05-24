using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEspecialBall : MonoBehaviour
{
    public float timePerShoot;
    public float time;
    public GameObject especialBall;

    GameObject ball;
    public float x;
    public float y;
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
                
                time=0;
                x= Random.Range(-speedBall,speedBall);
                y=speedBall-Mathf.Abs(x);
                if(Random.Range(0,2)==0)
                {
                    y=y*-1;
                }
                
                
                
                ball=Instantiate(especialBall, gameObject.transform.position, Quaternion.identity);
                ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(x,y),ForceMode2D.Impulse);
                timePerShoot=Random.Range(40,70);
                time=0;
            }

        }
    }
}
 