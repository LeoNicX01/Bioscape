using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_QuitButton : MonoBehaviour
{
    public void button_exit()
    {
    
        Application.Quit();
        Debug.Log("Babye");

    }

}
