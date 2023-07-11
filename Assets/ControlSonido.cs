using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonido : MonoBehaviour
{

    public AudioSource audioSource;
    public bool estadoAudio;

    private void Start() {
        audioSource=GetComponent<AudioSource>();
        estadoAudio=true;
    }

    

    public void EstadoAudio(){
        if(estadoAudio){
             audioSource.Pause();
             estadoAudio=false;
        }else{
            audioSource.Play();
            estadoAudio=true;
        }
    }

    public void Pause(){
        Debug.Log("BUTTON -> Pause");       
        Time.timeScale = 0f;
    }

public void Resume(){
        Debug.Log("BUTTON -> Resume");        
        Time.timeScale = 1f;
}
    
}
