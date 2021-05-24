using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;   
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class EstrellasMultiplayer : MonoBehaviour
{
    public static EstrellasMultiplayer estrellasMultiplayer;
    public int[] estrellas=new int[100];
    public String rutaArchivo;

    private void Awake() {
        rutaArchivo=Application.persistentDataPath+"/multiplayer.dat"; 
        if(estrellasMultiplayer==null)
        {
            estrellasMultiplayer=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(estrellasMultiplayer!=this)
            Destroy(gameObject);       
    }

    // Start is called before the first frame update
    void Start()
    {   CargarEstrellasNivel();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getStars(int nivel)
    {
       
        return estrellas[nivel];

    }

    public void BorrarEstrellas()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);

        DatosMultiplayer datos= new DatosMultiplayer();
        for (int i = 0; i < 100; i++)
        {
            datos.estrellas[i]=0;
        }
        bf.Serialize(file,datos);
        file.Close();

    }

    public void GuardarEstrellasNivel(int nivel,int numeroEstrellas)
    {
        
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);

        DatosMultiplayer datos= new DatosMultiplayer();
        datos.estrellas=estrellas;
        datos.estrellas[nivel]=numeroEstrellas;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void CargarEstrellasNivel()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);

            DatosMultiplayer datos=(DatosMultiplayer) bf.Deserialize(file);

            estrellas=datos.estrellas;

            file.Close();      
        }
        else
        {
            for(int i=0;i<100;i++)
            estrellas[i]=0;
        }
    }





}

[Serializable]
class DatosMultiplayer
{
    public int[] estrellas=new int[100];
}
