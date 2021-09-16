using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private enum Scene
    {
        Start,
        Game,
        Lose
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene((int) Scene.Lose);
    }

    public void LoadGameScene() {
        SceneManager.LoadScene((int) Scene.Game);
    }

    public void LoadStartMenu() {
        SceneManager.LoadScene((int) Scene.Start);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
