using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspecialBall : MonoBehaviour
{
    GameObject rectangulo;
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
            rectangulo=other.transform.parent.gameObject;
            for(int i=0;i<6;i++)
            rectangulo.transform.GetChild(i).gameObject.SetActive(true);
            rectangulo.gameObject.GetComponent<SurvRectangle>().UpdateColors();
        }   

    }





}
