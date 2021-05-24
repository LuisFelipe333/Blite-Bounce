using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSkinsInventory : MonoBehaviour
{
    public int limiteSkins;
    int ShopImage;
    GameObject marca;//es el circulo que señala que skin tienes
    public float posX;
    public float posY;
    public int colum;
    public GameObject shopPrefab;
    public GameObject objectShop;
    public GameObject colliderLimite;

    // Start is called before the first frame update
    void Start()
    {
        colum=1;
        posX=-260;
        posY=300;
        marca=GameObject.Find("ThisSkin");
        DatosSkins.datosSkins.CargarListaSkins();
        ShopImage=0;
        
        for(int i=0;i<limiteSkins;i++) //recorre todas las skins
        {
            
            //Debug.Log(DatosSkins.datosSkins.skins[i]);
            if(DatosSkins.datosSkins.skins[i])  //verifica si ya posees esa skin
            {
                //instancia un objeto por vender
                objectShop=Instantiate(shopPrefab,new Vector3(0,0,0),Quaternion.identity,gameObject.transform); //coloca la skin
                //objectShop.transform.SetParent(gameObject.transform);
                Debug.Log("Creado");
                objectShop.transform.GetChild(0).GetComponent<SaveNumberSkin>().numberSkin=i;   //obtener que skin es
                Debug.Log("JALO");
                Debug.Log("X="+posX+"Y="+posY);       //impeimir la posicion en la que estara el objeto
                Debug.Log("Parent: "+transform.parent.position.x);  //Imprimir posicion x
                Debug.Log("Parent: "+transform.parent.position.y);  //Imprimir posicion y
                
                objectShop.GetComponent<RectTransform>().localPosition=new Vector3(posX,posY,0);    //posiciona el objeto
                //transform.parent.position.x+
                //transform.parent.position.y+
                objectShop.GetComponent<Image>().sprite=DatosSkins.datosSkins.showSkin(i);  //le da forma al objeto
                objectShop.GetComponent<Image>().SetNativeSize();                           //lo coloca en su tamaño nativo
                if(i==DatosSkins.datosSkins.skinSeleccionada)                               //si la skin es la skin seleccionada coloca la palomita
                {
                    marca.transform.SetParent(objectShop.transform.GetChild(0));            //coloca la marca como un hijo del objeto
                    //marca.transform.parent=transform.GetChild(ShopImage).GetChild(0);
                    
                    marca.transform.position=new Vector3(objectShop.transform.GetChild(0).transform.position.x+Screen.width/10,objectShop.transform.GetChild(0).transform.position.y+Screen.height/28,0); //coloca la marca en la esquina superior derecha del objeto
                    
                }
                marca.transform.SetAsLastSibling();             //coloca la marca como el ultimo hijo
                if(colum==1||colum==2)                          //aumentan o disminuyen las coordenadas para asi se acomoden
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
        
        colliderLimite.transform.GetComponent<RectTransform>().localPosition=gameObject.transform.GetChild(gameObject.transform.childCount-1).GetComponent<RectTransform>().localPosition;
        colliderLimite.transform.GetComponent<RectTransform>().localPosition=new Vector3(0,colliderLimite.transform.GetComponent<RectTransform>().anchoredPosition.y-300,0);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
