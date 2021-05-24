using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCredits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f,700f,0f)*Time.deltaTime);
        if(transform.position.y>4000)
        SceneManager.LoadScene("Menu");
    }
}
