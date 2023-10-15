using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_StartButton : MonoBehaviour
{
    public void LoadScene(string Scene1)
    {
        SceneManager.LoadScene(Scene1);
    }
}
