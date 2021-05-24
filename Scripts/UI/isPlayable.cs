using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class isPlayable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!FinishedParts.finishedParts.parts[0])
        gameObject.GetComponent<Button>().interactable=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
