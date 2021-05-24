using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColorChange : MonoBehaviour
{
    public GameObject[] rentangles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sentSignal()
    {
        foreach (GameObject item in rentangles)
        {
            item.GetComponent<ChangeRectangle>().changeColor();
        }
    }

}
