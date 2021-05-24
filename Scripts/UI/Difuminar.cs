using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difuminar : MonoBehaviour
{
    public float opacity;
    bool increase;
    // Start is called before the first frame update
    void Start()
    {
        opacity=0;
        increase=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(increase&&opacity<1)
        opacity+=Time.deltaTime;
        
        if(!increase)
        opacity-=Time.deltaTime;

        if(opacity>1)
        StartCoroutine("ChangeIncrease");

        if(GetComponent<Image>()!=null)
        GetComponent<Image>().color= new Color(1f,1f,1f,opacity);

        if(GetComponent<Text>()!=null)
        GetComponent<Text>().color= new Color(1f,1f,1f,opacity);

    }

    IEnumerator ChangeIncrease()
    {
        yield return new WaitForSeconds(1);
        increase=false;
    }


}
