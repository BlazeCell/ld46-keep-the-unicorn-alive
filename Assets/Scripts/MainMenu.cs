using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGameEasy()
    {
        SceneManager.LoadScene("Easy");
    }
    public void PlayGameMedium()
    {
        SceneManager.LoadScene("Survival");
    }
    public void PlayGameHard()
    {
        SceneManager.LoadScene("Hard");
    }
}
