using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setTutorial : MonoBehaviour
{
    public GameObject[] textParts;
    public GameObject[] images;

    public GameObject blackBall;
    public GameObject whiteBall;

    public GameObject kingCat;

    public GameObject kingCatDialog;

    public String[] kingCatText;

    public String[] textoReyGato;

    public GameObject monsterHearts;

    public GameObject rectangulo;

    String textoMostrar;

    GameObject ball;

    public Joystick joystick;

    //public GameObject monster;

    public GameObject sceneCodder;

    // Start is called before the first frame update
    void Start()
    {
          if(!FinishedParts.finishedParts.parts[0])
            {
            Pause();
            StartCoroutine("StartTutorial");
            }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        gameObject.GetComponent<Shoot>().enabled=false;
        joystick.gameObject.SetActive(false);
    }

    public void Resume()
    {
        gameObject.GetComponent<Shoot>().enabled=true;
        joystick.gameObject.SetActive(true);
    }

    IEnumerator StartTutorial()
    {
        //muestra las flechas y vidas 
        yield return new WaitForSeconds(1f);
        textParts[0].SetActive(true);
        textParts[1].SetActive(true);
        images[0].SetActive(true);
        images[1].SetActive(true);
        yield return new WaitForSeconds(4f);
        textParts[0].SetActive(false);
        textParts[1].SetActive(false);
        images[0].SetActive(false);
        images[1].SetActive(false);
        yield return new WaitForSeconds(1f);


        //muestra el mounstruo y el boton de pausa 
        textParts[2].SetActive(true);
        textParts[3].SetActive(true);
        images[2].SetActive(true);
        images[3].SetActive(true);
        yield return new WaitForSeconds(4f);
        textParts[2].SetActive(false);
        textParts[3].SetActive(false);
        images[2].SetActive(false);
        images[3].SetActive(false);
        yield return new WaitForSeconds(1f);

        //muestra el como cambiar de color
        textParts[4].SetActive(true);
        images[4].SetActive(true);
        yield return new WaitForSeconds(4f);
        textParts[4].SetActive(false);
        images[4].SetActive(false);
        yield return new WaitForSeconds(0.5f);

        //muestra el como mover
        textParts[5].SetActive(true);
        images[5].SetActive(true);
        yield return new WaitForSeconds(4f);
        textParts[5].SetActive(false);
        images[5].SetActive(false);
        yield return new WaitForSeconds(0.5f);

        //muestra el como el enemigo dispara bolas
        textParts[6].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        ball=Instantiate(whiteBall, gameObject.transform.position, Quaternion.identity);
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,3),ForceMode2D.Impulse);
        yield return new WaitForSeconds(3f);
        textParts[6].SetActive(false);
        yield return new WaitForSeconds(0.5f);

        //muestra que el mismo color rebota
        textParts[7].SetActive(true);
        yield return new WaitForSeconds(3f);
        textParts[7].SetActive(false);
        yield return new WaitForSeconds(0.5f);

        //muestra que las pelotas le hacen daño al enemigo
        textParts[8].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        ball=Instantiate(whiteBall, gameObject.transform.position, Quaternion.identity);
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(3,0),ForceMode2D.Impulse);
        yield return new WaitForSeconds(3f);
        textParts[8].SetActive(false);
        yield return new WaitForSeconds(0.5f);

        //muestra que diferente color destruye
        textParts[9].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        ball=Instantiate(blackBall, gameObject.transform.position, Quaternion.identity);
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-3),ForceMode2D.Impulse);
        yield return new WaitForSeconds(3f);
        textParts[9].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        
        //muestra que si la pelota se sale te quita vida
        textParts[10].SetActive(true);
        yield return new WaitForSeconds(1f);
        ball=Instantiate(whiteBall, gameObject.transform.position, Quaternion.identity);
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(1.5f,-1.5f),ForceMode2D.Impulse);
        yield return new WaitForSeconds(3.5f);
        textParts[10].SetActive(false);
        yield return new WaitForSeconds(0.5f);

        //Escribe el texto dicho por el rey gato
        kingCat.SetActive(true);
        if(Idioma.idioma.idiomaSeleccionado==0)
        {
            for(int i=0;i<2;i++)
            {
                textoMostrar="";
                for(int j=0;j<kingCatText[i].Length;j++)
                {
                    textoMostrar=string.Concat(textoMostrar,kingCatText[i][j]);
                    kingCatDialog.GetComponent<Text>().text=textoMostrar;
                    yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }
            textoMostrar="";

        }

        if(Idioma.idioma.idiomaSeleccionado==1)
        {
            for(int i=0;i<2;i++)
            {
                textoMostrar="";
                for(int j=0;j<textoReyGato[i].Length;j++)
                {
                    textoMostrar=string.Concat(textoMostrar,textoReyGato[i][j]);
                    kingCatDialog.GetComponent<Text>().text=textoMostrar;
                    yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
                
            }
            textoMostrar="";
        }

        kingCat.SetActive(false);
        monsterHearts.GetComponent<MonsterHearts>().totalLife=3;
        for(int i=0;i<6;i++)
            rectangulo.transform.GetChild(i).gameObject.SetActive(true);
        Resume();

    }

    public void FinishedFirstLevel(){
        StartCoroutine("WaitForFinished");
    }

    IEnumerator WaitForFinished()
    {
        sceneCodder.GetComponent<WinsControl>().doIt=false;
        Pause();
        kingCat.SetActive(true);

        if(Idioma.idioma.idiomaSeleccionado==0)
        {
            for(int i=2;i<4;i++)
            {
                textoMostrar="";
                for(int j=0;j<kingCatText[i].Length;j++)
                {
                    textoMostrar=string.Concat(textoMostrar,kingCatText[i][j]);
                    kingCatDialog.GetComponent<Text>().text=textoMostrar;
                    yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
            }

            textoMostrar="";
        }

        if(Idioma.idioma.idiomaSeleccionado==1)
        {
            for(int i=2;i<4;i++)
            {
                textoMostrar="";
                for(int j=0;j<textoReyGato[i].Length;j++)
                {
                    textoMostrar=string.Concat(textoMostrar,textoReyGato[i][j]);
                    kingCatDialog.GetComponent<Text>().text=textoMostrar;
                    yield return new WaitForSeconds(0.02f);
                }
                yield return new WaitForSeconds(4f);
                
            }
            textoMostrar="";
        }


        
        FinishedParts.finishedParts.parts[0]=true;      //marca que termino el tutorial
        FinishedParts.finishedParts.GuardarPartes();    //lo guarda

        EstadoJuego.estadoJuego.numeroEstrellas=EstadoJuego.estadoJuego.numeroEstrellas+10; //suma las 10 estrellas
        EstadoJuego.estadoJuego.GuardarEstrellas();                                         //las guarda

        yield return new WaitForSeconds(2f);
        sceneCodder.GetComponent<WinsControl>().doIt=true;
        sceneCodder.GetComponent<WinsControl>().StartCoroutine("PauseButtons"); //coloca los botones
        kingCat.SetActive(false);
    }


}
