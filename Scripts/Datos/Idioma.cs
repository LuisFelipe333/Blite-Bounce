using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class Idioma : MonoBehaviour
{

    //0= Ingles
    //1= Español
    
    public int idiomaSeleccionado;
    public static Idioma idioma;
    public String rutaArchivo;

    void Awake() {
        rutaArchivo=Application.persistentDataPath+"/idioma.dat";
        if(idioma==null)
        {
            idioma=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(idioma!=this)
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        CargarIdioma();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GuardarIdioma(int nuevoIdioma)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);

        IdiomaAGuardar datos= new IdiomaAGuardar();
        idiomaSeleccionado=nuevoIdioma;
        datos.idiomaSeleccionado=idiomaSeleccionado;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void CargarIdioma()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);

            IdiomaAGuardar datos=(IdiomaAGuardar) bf.Deserialize(file);

            idiomaSeleccionado=datos.idiomaSeleccionado;

            file.Close();      
        }
        else
        {
            idiomaSeleccionado=2;
        }
    }



}

[Serializable]
class IdiomaAGuardar
{
    public int idiomaSeleccionado; 

}