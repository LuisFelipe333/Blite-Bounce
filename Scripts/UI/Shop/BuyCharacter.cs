using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BuyCharacter : MonoBehaviour
{
    GameObject imageCharacter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buyOnClicked()
    {
        //GameObject.Find("BuyCharacter").GetComponent<MakeBuy>().buyMaked(gameObject.GetComponentInParent<SaveSkinNumber>().skinNumber);
        
        IAPManager.instance.BuyCharacter(GetComponentInParent<SaveSkinNumber>().skinNumber);
    }

    


}
