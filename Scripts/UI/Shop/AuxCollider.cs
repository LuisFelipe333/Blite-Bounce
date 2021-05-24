using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuxCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Enter "+ gameObject);
        if(other.tag=="LimiteSuperior")
        gameObject.GetComponentInParent<MoveShop>().up=true;
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Exit");
        if(other.tag=="LimiteSuperior")
        gameObject.GetComponentInParent<MoveShop>().up=false;  
        
    }

}
