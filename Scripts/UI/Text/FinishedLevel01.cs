using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedLevel01 : MonoBehaviour
{
    bool can;
    public GameObject monster;
    // Start is called before the first frame update
    void Start()
    {
        can=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<MonsterHearts>().totalLife==0&&!FinishedParts.finishedParts.parts[0]&&can)
        {
            can=false;
            monster.GetComponent<setTutorial>().FinishedFirstLevel();
        }

    }
}
