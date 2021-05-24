using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyChest : MonoBehaviour
{
    public AudioClip chestSound;
    public int limiteSkins;//NUMERO MAYOR DEL ARREGLO (TAMAÑO ARREGLO -1)
    int skinConseguida;
    public Image skinCofre;
    float i;
    bool change;
    public GameObject chest;
    public GameObject padreTienda;
    bool faltanSkin;
    // Start is called before the first frame update
    void Start()
    {
        change=false;
        faltanSkin=false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if(change)
        {   
            if(i<=1)
            {
                skinCofre.GetComponent<RectTransform>().localScale=new Vector3(i,i,0);
                i+=0.01f;
            }
            else
            {
                i=0;
                change=false;
                StartCoroutine("WaitForReduce");
            }
        
        }
    }

    public void RealizarCompra()
    {

        for(int j=1;j<limiteSkins+1;j++)
        {
            if(!DatosSkins.datosSkins.skins[j])
            faltanSkin=true;
            Debug.Log(DatosSkins.datosSkins.skins[j]);
        }
        Debug.Log("Ya");

        if(EstadoJuego.estadoJuego.numeroEstrellas>=10&&faltanSkin)
        {
            do
            {
                
                skinConseguida=Random.Range(2,limiteSkins+1);
                Debug.Log("Generado"+skinConseguida);
                
            } while (DatosSkins.datosSkins.skins[skinConseguida]); 

            Debug.Log("Final"+skinConseguida); 
            //Quita las 10 estrellas
            EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas-10;
            EstadoJuego.estadoJuego.GuardarEstrellas();
            //te guarda la skin como obtenida
            DatosSkins.datosSkins.skinConseguida=this.skinConseguida;
            DatosSkins.datosSkins.GuardarListaSkins();
            //selecciona la skin como skin conseguida
            DatosSkins.datosSkins.skinSeleccionada=skinConseguida;
            DatosSkins.datosSkins.GuardarSkinSeleccionada();
            //muestra la skin
            skinCofre.GetComponent<Image>().sprite=DatosSkins.datosSkins.showSkin(skinConseguida);
            skinCofre.GetComponent<Image>().SetNativeSize();
            change=true;
            chest.GetComponent<Animator>().SetBool("Opening",true);
            Debug.Log("Reproducir sonido");
            AudioSource.PlayClipAtPoint(chestSound, new Vector3(0f,0f));
            //padreTienda.transform.GetChild(padreTienda.GetComponent<ColocateSkinsShop>().ShopImage-1).gameObject.SetActive(false);
            padreTienda.GetComponent<ColocateSkinsShop>().actualizar();
        }
        faltanSkin=false;

    }

     IEnumerator WaitForReduce()
    {
        yield return new WaitForSeconds(3);
        skinCofre.GetComponent<RectTransform>().localScale=new Vector3(0,0,0);
        chest.GetComponent<Animator>().SetBool("Opening",false);
    }


}
