using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class FinishedParts : MonoBehaviour
{
    public static FinishedParts finishedParts;
    public String rutaArchivo;
    public bool[] parts=new bool[10];
    /*
    0=dialogo nivel 1
    1=multiplayer nivel 1
    2=survival
    3=escudos
    4=ultimo nivel
    */

    void Awake() {
        rutaArchivo=Application.persistentDataPath+"/partes.dat";
        if(finishedParts==null)
        {
            finishedParts=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(finishedParts!=this)
            Destroy(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        CargarPartes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void GuardarPartes()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);

        PartesAGuardar datos= new PartesAGuardar();
        datos.parts=parts;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void CargarPartes()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);

            PartesAGuardar datos=(PartesAGuardar) bf.Deserialize(file);

            parts=datos.parts;

            file.Close();      
        }
        else
        {
            for(int i=0;i<10;i++)
            parts[i]=false;
        }
    }



}
[Serializable]
class PartesAGuardar
{
    public bool[] parts=new bool[10];
}
