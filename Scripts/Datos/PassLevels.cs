using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassLevels : MonoBehaviour
{

    public int maxLevelMulti;
    public int maxLevelSingle;

    public bool activateSingle;
    public bool activateMulti;


    // Start is called before the first frame update
    void Start()
    {
        if(activateMulti)
        putMultiplayerStars();

        if(activateSingle)
        putSingleStars();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void putMultiplayerStars()
    {
        EstrellasMultiplayer.estrellasMultiplayer.BorrarEstrellas();
        for(int i=0;i<=maxLevelMulti;i++)
        {
            EstrellasMultiplayer.estrellasMultiplayer.GuardarEstrellasNivel(i,3);
        }
    }

    void putSingleStars()
    {
        EstrellasPorNivel.estrellasPorNivel.BorrarEstrellas();
        for(int i=0;i<=maxLevelMulti;i++)
        {
            EstrellasPorNivel.estrellasPorNivel.GuardarEstrellasNivel(i,3);
        }
    }


}
