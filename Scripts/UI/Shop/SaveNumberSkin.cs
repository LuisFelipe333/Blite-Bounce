using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveNumberSkin : MonoBehaviour//guarda la skin del inventario de skins
{
    public int numberSkin;
    GameObject marca;
    // Start is called before the first frame update
    void Start()
    {
        marca=GameObject.Find("ThisSkin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSkin()
    {
        marca.transform.SetParent(this.gameObject.transform);
        //marca.transform.parent=this.gameObject.transform;
        marca.transform.position=new Vector3(transform.position.x+Screen.width/10,transform.position.y+Screen.height/22,0);
        DatosSkins.datosSkins.skinSeleccionada=numberSkin;
        DatosSkins.datosSkins.GuardarSkinSeleccionada();

    }
}
