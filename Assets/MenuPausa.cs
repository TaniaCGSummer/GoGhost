using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public void PauseGame()
   
    {
        Time.timeScale = 0;
    }
    public void ReanudarGame()
    {
        Time.timeScale = 1;
    }


}
