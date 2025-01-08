using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class basla : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayIntro()
    {
        SceneManager.LoadScene("MenuScene2");
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }


}
