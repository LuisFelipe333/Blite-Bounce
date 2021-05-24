using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DatosSkins : MonoBehaviour
{
    public bool[] skins=new bool[100];
    public AudioClip[] sounds;
    public static DatosSkins datosSkins;
    public String rutaArchivo;
    public int skinConseguida;
    bool activacionSkin;
    public int skinSeleccionada;
    public Sprite[] listaSkins;
    public String[] llavesVenta;

    void Awake() {
        rutaArchivo=Application.persistentDataPath+"/skins.dat";
        if(datosSkins==null)
        {
            datosSkins=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(datosSkins!=this)
            Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        CargarListaSkins();
        CargarSkinSeleccionada();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite ObtenerSkin()
    {
        return listaSkins[skinSeleccionada];
    }

    public AudioClip ObtenerSonido()
    {
        return sounds[skinSeleccionada];
    }

    public Sprite showSkin(int i)
    {
        return listaSkins[i];
    }

    public void GuardarListaSkins()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);

        DatosDeSkins datos= new DatosDeSkins();
        datos.skins=skins;
        datos.skinSeleccionada=skinSeleccionada;
        datos.skins[skinConseguida]=true;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void CagarListaSkins()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);
        
        DatosDeSkins datos= new DatosDeSkins();
        datos.skinSeleccionada=1;
        skinSeleccionada=1;
        datos.skins[1]=true;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void CargarListaSkins()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);

            DatosDeSkins datos=(DatosDeSkins) bf.Deserialize(file);

            skins=datos.skins;

            file.Close();      
        }
        else
        {
            skins[1]=true;
        }
    }


public void GuardarSkinSeleccionada()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);

        DatosDeSkins datos= new DatosDeSkins();
        datos.skins=skins;
        datos.skinSeleccionada=skinSeleccionada;
        bf.Serialize(file,datos);
        file.Close();
    }



    public void CargarSkinSeleccionada()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);

            DatosDeSkins datos=(DatosDeSkins) bf.Deserialize(file);

            skinSeleccionada=datos.skinSeleccionada;

            file.Close();      
        }
        else
        {
            skinSeleccionada=1;
        }
    }

    

}

[Serializable]
class DatosDeSkins
{
    public int skinSeleccionada;
    public bool[] skins=new bool[100];
}
