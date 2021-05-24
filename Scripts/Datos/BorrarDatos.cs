using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarDatos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EstadoJuego.estadoJuego.numeroEstrellas=300;
        EstadoJuego.estadoJuego.GuardarEstrellas(); 
        DatosSkins.datosSkins.CagarListaSkins();
        Idioma.idioma.GuardarIdioma(2);
        Volume.volume.setVolume(0.5f);
        Volume.volume.GuardarVolume();
        EstrellasPorNivel.estrellasPorNivel.BorrarEstrellas();
        EstrellasMultiplayer.estrellasMultiplayer.BorrarEstrellas();
        FinishedParts.finishedParts.parts[0]=false;
        FinishedParts.finishedParts.parts[1]=false;
        FinishedParts.finishedParts.parts[2]=false;
        FinishedParts.finishedParts.parts[3]=false;
        FinishedParts.finishedParts.parts[4]=false;
        FinishedParts.finishedParts.GuardarPartes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


}
