using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHearts : MonoBehaviour
{
    public Sprite[] Hearts;
    public int totalLife;
    public GameObject WinController;

    // Start is called before the first frame update
    void Start()
    {
         this.GetComponent<Image>().sprite=Hearts[totalLife];
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Image>().sprite=Hearts[totalLife];
        if(totalLife==0)
        {
        WinController.GetComponent<WinsControl>().CheckWin(true);
        }
        
        

    }

    public void offLife(int substract)
    {
        if(totalLife>0)
        totalLife=totalLife-substract;
    }


}
