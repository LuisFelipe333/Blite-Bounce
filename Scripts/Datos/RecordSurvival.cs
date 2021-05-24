using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class RecordSurvival : MonoBehaviour
{
    public float record;
    public static RecordSurvival recordSurvival;
    public String rutaArchivo;

    void Awake() {
        rutaArchivo=Application.persistentDataPath+"/record.dat";
        if(recordSurvival==null)
        {
            recordSurvival=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(recordSurvival!=this)
            Destroy(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        CargarRecord();
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void GuardarRecord()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);
        
        Record datos= new Record();
        datos.record=record;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void CargarRecord()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);

            Record datos=(Record) bf.Deserialize(file);

            record=datos.record;

            file.Close();      
        }
        else
        {
            record=0;
        }
    }



}

[Serializable]
class Record
{
    public float record; 

}
