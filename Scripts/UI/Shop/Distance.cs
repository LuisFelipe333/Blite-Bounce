using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getDistance()
    {
        return Vector3.Distance(object1.transform.position,object2.transform.position);
    }

}
