using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarDificultad : MonoBehaviour
{
    public GameObject Monster;
    public float escala;
    // Start is called before the first frame update
    void Start()
    {
        escala=1;
    }

    // Update is called once per frame
    void Update()
    {
        escala-=Time.deltaTime/1000;
        if(Monster.GetComponent<Shoot>().timePerShoot>2)
        Monster.GetComponent<Shoot>().timePerShoot-=(Time.deltaTime/70);
        if(Monster.GetComponent<Shoot>().speedBall<5)
        Monster.GetComponent<Shoot>().speedBall+=(Time.deltaTime/120);
        if(escala>0.7)
        Monster.GetComponent<Transform>().localScale=new Vector3(escala,escala,0);
    }

}
