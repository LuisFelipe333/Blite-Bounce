using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeHeart : MonoBehaviour
{
    
    public Sprite[] Hearts;
    public int totalLife;
    public GameObject WinController;
    bool titleShow;
    // Start is called before the first frame update
    void Start()
    {
        titleShow=false;
         this.GetComponent<Image>().sprite=Hearts[totalLife];
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Image>().sprite=Hearts[totalLife];
        if(totalLife==0&&!titleShow){
        WinController.GetComponent<WinsControl>().CheckWin(false);
        titleShow=true;
        }

    }

    public void offLife(int substract)
    {
        if(totalLife>0)
        totalLife=totalLife-substract;
    }


}
