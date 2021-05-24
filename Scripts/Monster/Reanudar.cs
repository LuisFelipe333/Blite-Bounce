using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reanudar : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReanudarJuego()
    {
        Time.timeScale=1;
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);
        gameObject.SetActive(false);
    }
}
