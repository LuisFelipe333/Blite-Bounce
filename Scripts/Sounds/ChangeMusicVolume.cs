using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicVolume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Slider>().value=Volume.volume.actualVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeVolume(float vol)
    {
        Volume.volume.setVolume(vol);
        Volume.volume.GuardarVolume();
        SoundsController.soundsController.setVolume();
    }
}
