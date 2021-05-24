using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MostrarRecord : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text="Record: "+RecordSurvival.recordSurvival.record.ToString("N1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
