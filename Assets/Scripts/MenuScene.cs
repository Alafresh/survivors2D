using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    public void PlayBtn()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void MenuBtn()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void ExitBtn()
    {
        Application.Quit();
    }
}
