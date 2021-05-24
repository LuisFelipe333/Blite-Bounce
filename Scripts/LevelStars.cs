using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStars : MonoBehaviour
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
       
            EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+(3-EstrellasPorNivel.estrellasPorNivel.getStars(nivel));
            EstadoJuego.estadoJuego.GuardarEstrellas();
            EstrellasPorNivel.estrellasPorNivel.GuardarEstrellasNivel(nivel,3);
    }
    else if(puntosPerdidos<DosEstrellasMaximo)
        {
        estrella1.SetActive(true);
        estrella2.SetActive(true);
                if(EstrellasPorNivel.estrellasPorNivel.getStars(nivel)<2)
                {
                EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+(2-EstrellasPorNivel.estrellasPorNivel.getStars(nivel));
                EstadoJuego.estadoJuego.GuardarEstrellas(); 
                EstrellasPorNivel.estrellasPorNivel.GuardarEstrellasNivel(nivel,2);
                }
            
        }
        else
        {
            estrella1.SetActive(true);
            if(EstrellasPorNivel.estrellasPorNivel.getStars(nivel)<1)
                {
                EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+(1-EstrellasPorNivel.estrellasPorNivel.getStars(nivel));
                EstadoJuego.estadoJuego.GuardarEstrellas();
                EstrellasPorNivel.estrellasPorNivel.GuardarEstrellasNivel(nivel,1);
                }
        }
    
    }

}
