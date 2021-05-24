using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class EstadoJuego : MonoBehaviour
{
    public int numeroEstrellas=0;
    public static EstadoJuego estadoJuego;
    public String rutaArchivo;

    void Awake() {
        rutaArchivo=Application.persistentDataPath+"/datos.dat";
        if(estadoJuego==null)
        {
            estadoJuego=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(estadoJuego!=this)
            Destroy(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        Cargar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void GuardarEstrellas()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);

        DatosAGuardar datos= new DatosAGuardar();
        datos.numeroEstrellas=numeroEstrellas;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void Cargar()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);

            DatosAGuardar datos=(DatosAGuardar) bf.Deserialize(file);

            numeroEstrellas=datos.numeroEstrellas;

            file.Close();      
        }
        else
        {
            numeroEstrellas=0;
        }
    }



}
[Serializable]
class DatosAGuardar
{
    public int numeroEstrellas; 

}
