using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedLevel30 : MonoBehaviour
{
    bool can;
    public GameObject Kingcat;
    // Start is called before the first frame update
    void Start()
    {
        can=true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Si entro");
        if(gameObject.GetComponent<MonsterHearts>().totalLife==0&&!FinishedParts.finishedParts.parts[4]&&can)
        {
            Debug.Log("Aqui tambien");
            can=false;
            Kingcat.SetActive(true);
            Kingcat.GetComponent<setTextLevel30>().FinishLevel30();
        }

    }

}
