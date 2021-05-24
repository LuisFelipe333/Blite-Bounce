using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContenedorSkins : MonoBehaviour
{
    public Sprite[] listaSkins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite obtenerSkin(int skinSeleccionada)
    {
        return listaSkins[skinSeleccionada];
    }
}
