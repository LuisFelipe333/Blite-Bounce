using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLevelStars : MonoBehaviour
{
    public int cantidadNiveles;
    public int numeroEstrellas;
    public Sprite candado;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<cantidadNiveles;i++)
        {   
        
            numeroEstrellas=EstrellasPorNivel.estrellasPorNivel.getStars(gameObject.transform.GetChild(i).GetComponent<GoToLevel>().nivel);
            if(0<numeroEstrellas)
            {
                for(int j=0;j<numeroEstrellas;j++)
                {
                    gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);
                }   
            }
            else
            {
                for(int j=i+1;j<cantidadNiveles;j++)
                {
                    gameObject.transform.GetChild(j).GetComponent<Image>().sprite=candado;
                    gameObject.transform.GetChild(j).GetComponent<Button>().interactable=false;
                    i=cantidadNiveles;
                }   
            }
            

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

