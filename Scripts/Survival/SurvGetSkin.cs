using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvGetSkin : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SurvMonsterSound>().sound=DatosSkins.datosSkins.ObtenerSonido();
        gameObject.GetComponent<SpriteRenderer>().sprite=DatosSkins.datosSkins.ObtenerSkin();
        gameObject.GetComponent<SpriteRenderer>().sortingOrder=1;
    }
}
