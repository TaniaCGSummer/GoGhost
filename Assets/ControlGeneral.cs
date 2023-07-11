using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlGeneral : MonoBehaviour
{

   

 
    

    public void CambioEscena(int N_escena){
        SceneManager.LoadScene(N_escena);
    }



}
