using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
    public static SoundsController soundsController;
    public GameObject buttonSound;
    public GameObject matchSong;
    public GameObject MenuSong;
    
    public GameObject musicaActualMatch;
    public GameObject musicaActualMenu;

    public float actualVolume;
    void Awake() {
            
        if(soundsController==null)
        {
            musicaActualMenu=Instantiate(MenuSong);
            DontDestroyOnLoad(musicaActualMenu);
            soundsController=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(soundsController!=this)
            Destroy(gameObject);

        setVolume();
    }

    public void playButtonSound()
    {
        Debug.Log("Playing Sound");
        //AudioSource.PlayClipAtPoint(buttonSound,transform.position);
        Instantiate(buttonSound);
    }
    
    public void changeToMatchSong()
    {   
        if(musicaActualMatch==null){
        Destroy(musicaActualMenu);
       
        musicaActualMatch=Instantiate(matchSong);
        DontDestroyOnLoad(musicaActualMatch);
        
        }

        setVolume();
    }

    public void changeToMenuSong()
    {
        if(musicaActualMenu==null)
        {
            musicaActualMenu=Instantiate(MenuSong);
            DontDestroyOnLoad(musicaActualMenu);
        }

        if(musicaActualMatch!=null)
        Destroy(musicaActualMatch);

        setVolume();
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setVolume()
    {

        actualVolume=Volume.volume.actualVolume;

        if(musicaActualMatch!=null)
        musicaActualMatch.GetComponent<AudioSource>().volume=actualVolume;

        if(musicaActualMenu!=null)
        musicaActualMenu.GetComponent<AudioSource>().volume=actualVolume;
    }


}
