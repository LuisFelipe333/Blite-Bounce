using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;   
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class EstrellasPorNivel : MonoBehaviour
{
    public static EstrellasPorNivel estrellasPorNivel;
    public int[] estrellas=new int[100];
    public String rutaArchivo;

    private void Awake() {
        rutaArchivo=Application.persistentDataPath+"/niveles.dat"; 
        if(estrellasPorNivel==null)
        {
            estrellasPorNivel=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(estrellasPorNivel!=this)
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

        DatosNiveles datos= new DatosNiveles();
        for (int i = 0; i < 100; i++)
        {
            datos.estrellas[i]=0;
        }

        for (int i = 0; i < 30; i++)
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

        DatosNiveles datos= new DatosNiveles();
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

            DatosNiveles datos=(DatosNiveles) bf.Deserialize(file);

            estrellas=datos.estrellas;

            file.Close();      
        }
        else
        {
            for(int i=0;i<100;i++)
            estrellas[i]=0;
            //quitar
            //for(int i=0;i<20;i++)
            //estrellas[i]=1;
        }
    }





}

[Serializable]
class DatosNiveles
{
    public int[] estrellas=new int[100];
}
