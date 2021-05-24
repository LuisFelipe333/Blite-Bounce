using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeBuy : MonoBehaviour
{
    GameObject imageCharacter;
    public GameObject padre;
    // Start is called before the first frame update
    void Start()
    {
        imageCharacter=this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buyMaked(int skinComprada)
    {
        DatosSkins.datosSkins.skinConseguida=skinComprada;
        DatosSkins.datosSkins.skinSeleccionada=skinComprada;
        DatosSkins.datosSkins.GuardarListaSkins();
        imageCharacter.GetComponent<Image>().sprite=DatosSkins.datosSkins.showSkin(skinComprada);
        imageCharacter.GetComponent<Image>().SetNativeSize();
        StartCoroutine("scaleObject");
    }

    IEnumerator scaleObject()
    {        
        for(float i=0;i<=1.5;i+=0.02f)
        {
            imageCharacter.GetComponent<RectTransform>().localScale=new Vector3(i,i,0);
            yield return new WaitForSeconds(0.008f);
        }
        padre.GetComponent<ColocateSkinsShop>().actualizar();
        yield return new WaitForSeconds(0.5f);
        imageCharacter.GetComponent<RectTransform>().localScale=new Vector3(0,0,0);

    }





}
