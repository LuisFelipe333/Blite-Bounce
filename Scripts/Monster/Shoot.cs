using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float timePerShoot;
    public float time;
    public GameObject blackBall;
    public GameObject whiteBall;
    GameObject ball;
    public float x;
    public float y;
    public float speedBall;
    public bool setActive;
    // Start is called before the first frame update
    void Start()
    {
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
            {   time=0;
                x= Random.Range(-speedBall,speedBall);
                y=speedBall-Mathf.Abs(x);
                if(Random.Range(0,2)==0)
                {
                    y=y*-1;
                }
                
                
                if(Random.Range(0,2)==0)
                ball=Instantiate(whiteBall, gameObject.transform.position, Quaternion.identity);
                else
                ball=Instantiate(blackBall, gameObject.transform.position, Quaternion.identity);

                ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(x,y),ForceMode2D.Impulse);
                    
            }

        }
    }
}
 