using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Volume : MonoBehaviour
{
     public float actualVolume;
    public static Volume volume;
    public String rutaArchivo;

    void Awake() {
        rutaArchivo=Application.persistentDataPath+"/volumen.dat";
        if(volume==null)
        {
            volume=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(volume!=this)
            Destroy(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        CargarVolume();
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void setVolume(float volume)
    {
        this.actualVolume=volume;
    }

    public void GuardarVolume()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);
        
        ActualVolume datos= new ActualVolume();
        datos.actualVolume=actualVolume;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void CargarVolume()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);
            Debug.Log("Si existe carnal y vale");
            ActualVolume datos=(ActualVolume) bf.Deserialize(file);

            actualVolume=datos.actualVolume;

            

            file.Close();      
        }
        else
        {
            actualVolume=0.5f;
        }
    }



}

[Serializable]
class ActualVolume
{
    public float actualVolume; 

}
