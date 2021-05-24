using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColocateSkinsShop : MonoBehaviour
{
    public int limiteSkins;//tamaño arreglo
    public int ShopImage;
    public float posX;
    public float posY;
    public int colum;
    public GameObject shopPrefab;
    public GameObject objectShop;
    public GameObject buyStarsButton;
    public GameObject adForStarsButton;
    public GameObject supportDeveloper;
    public GameObject limiteSuperior;
    // Start is called before the first frame update
    void Start()
    {   colum=1;
        posX=-260;
        posY=300;
        DatosSkins.datosSkins.CargarListaSkins();
        ShopImage=0;
        //joystick.GetComponent<RectTransform>().sizeDelta=new Vector2(joystick.GetComponent<RectTransform>().sizeDelta.x,gameObject.GetComponent<Distance>().getDistance());
        //Debug.Log(gameObject.GetComponent<Distance>().getDistance());
        for(int i=1;i<limiteSkins;i++)
        {
            
            //Debug.Log(DatosSkins.datosSkins.skins[i]);
            if(!DatosSkins.datosSkins.skins[i])
            {
                //instancia un objeto por vender
                objectShop=Instantiate(shopPrefab,new Vector3(0,0,0),Quaternion.identity,gameObject.transform);
                //objectShop.transform.SetParent(gameObject.transform);
                objectShop.GetComponent<SaveSkinNumber>().skinNumber=i;
                Debug.Log("X="+posX+"Y="+posY);
                Debug.Log("Parent: "+transform.parent.position.x);
                Debug.Log("Parent: "+transform.parent.position.y);
                
                objectShop.GetComponent<RectTransform>().localPosition=new Vector3(posX,posY,0);
                //transform.parent.position.x+
                //transform.parent.position.y+
                objectShop.GetComponent<Image>().sprite=DatosSkins.datosSkins.showSkin(i);
                objectShop.GetComponent<Image>().SetNativeSize();
                if(colum==1||colum==2)//aumentan o disminuyen las coordenadas para asi se acomoden
                {
                    posX+=260;
                    colum++;
                }else if(colum==3)
                {
                    posX-=520;
                    posY-=300;
                    colum=1;
                }
                
                /*transform.GetChild(ShopImage).GetComponent<Image>().sprite=DatosSkins.datosSkins.showSkin(i);
                transform.GetChild(ShopImage).GetComponent<Image>().SetNativeSize();
                ShopImage++;*/  
            }
        }

        if(colum!=1)
        posY-=300;

        buyStarsButton.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,posY,0);
        adForStarsButton.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,posY-150,0);
        supportDeveloper.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,posY-300,0);

        //buyStarsButton.transform.GetComponent<RectTransform>().localPosition=gameObject.transform.GetChild(gameObject.transform.childCount-1).GetComponent<RectTransform>().localPosition;
        //buyStarsButton.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,buyStarsButton.transform.GetComponent<RectTransform>().anchoredPosition.y-300,0);

        //limiteSuperior.transform.GetComponent<RectTransform>().localPosition=gameObject.transform.GetChild(gameObject.transform.childCount-1).GetComponent<RectTransform>().localPosition;
        //limiteSuperior.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,buyStarsButton.transform.GetComponent<RectTransform>().anchoredPosition.y-300,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void actualizar(){
        
        int i;
        ShopImage=0;
        //checa todos los hijos del objeto hasta que se acaben o que uno su skin sea verdadera
        for(i=3;i<gameObject.transform.childCount&&!DatosSkins.datosSkins.skins[gameObject.transform.GetChild(i).GetComponent<SaveSkinNumber>().skinNumber];i++)
        {
            Debug.Log(i);
        }
        Debug.Log("i= "+i);
        for(int j=gameObject.transform.childCount-1;j>i;j--)
        {
        gameObject.transform.GetChild(j).GetComponent<RectTransform>().localPosition=gameObject.transform.GetChild(j-1).GetComponent<RectTransform>().localPosition;
        Debug.Log((j)+" obtiene la posicion de "+(j-1));
        }

        Destroy(gameObject.transform.GetChild(i).gameObject);
        Debug.Log(gameObject.transform.childCount-1);
        buyStarsButton.transform.GetComponent<RectTransform>().localPosition=gameObject.transform.GetChild(gameObject.transform.childCount-1).GetComponent<RectTransform>().localPosition;
        buyStarsButton.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,buyStarsButton.transform.GetComponent<RectTransform>().anchoredPosition.y-300,0);
        
        adForStarsButton.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,buyStarsButton.transform.GetComponent<RectTransform>().anchoredPosition.y-150,0);
        supportDeveloper.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,buyStarsButton.transform.GetComponent<RectTransform>().anchoredPosition.y-300,0);

        //buyStarsButton.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,gameObject.transform.GetChild(gameObject.transform.childCount-1).GetComponent<RectTransform>().localPosition.y,0);
        //adForStarsButton.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,gameObject.transform.GetChild(gameObject.transform.childCount-1).GetComponent<RectTransform>().localPosition.y-150,0);
        //supportDeveloper.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,gameObject.transform.GetChild(gameObject.transform.childCount-1).GetComponent<RectTransform>().localPosition.y-300,0);

        //limiteSuperior.transform.GetComponent<RectTransform>().localPosition=gameObject.transform.GetChild(gameObject.transform.childCount-1).GetComponent<RectTransform>().localPosition;
        //limiteSuperior.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,buyStarsButton.transform.GetComponent<RectTransform>().anchoredPosition.y-300,0);
    }
}
