using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMultiplayerStars : MonoBehaviour
{
    public int puntosPerdidos;
    public int UnaEstrellaMaximo;
    public int DosEstrellasMaximo;
    public int TresEstrellasMaximo;
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;
    public int nivel;
    // Start is called before the first frame update
    void Start()
    {
        puntosPerdidos=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getStars()
    {
    if(puntosPerdidos<UnaEstrellaMaximo)
    {
        estrella1.SetActive(true);
        estrella2.SetActive(true);
        estrella3.SetActive(true);
       
            EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+(3-EstrellasMultiplayer.estrellasMultiplayer.getStars(nivel));
            EstadoJuego.estadoJuego.GuardarEstrellas();
            EstrellasMultiplayer.estrellasMultiplayer.GuardarEstrellasNivel(nivel,3);
    }
    else if(puntosPerdidos<DosEstrellasMaximo)
        {
        estrella1.SetActive(true);
        estrella2.SetActive(true);
                if(EstrellasMultiplayer.estrellasMultiplayer.getStars(nivel)<2)
                {
                EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+(2-EstrellasMultiplayer.estrellasMultiplayer.getStars(nivel));
                EstadoJuego.estadoJuego.GuardarEstrellas();
                EstrellasMultiplayer.estrellasMultiplayer.GuardarEstrellasNivel(nivel,2);
                }
            
        }
        else
        {
            estrella1.SetActive(true);
            if(EstrellasMultiplayer.estrellasMultiplayer.getStars(nivel)<1)
                {
                EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+(1-EstrellasMultiplayer.estrellasMultiplayer.getStars(nivel));
                EstadoJuego.estadoJuego.GuardarEstrellas();
                EstrellasMultiplayer.estrellasMultiplayer.GuardarEstrellasNivel(nivel,1);
                }
        }
    
    }

}

//esto va en el padre de los botones de seleccion de nivel multiplayer