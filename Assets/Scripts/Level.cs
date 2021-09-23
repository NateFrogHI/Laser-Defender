using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2;

    private enum Scene
    {
        Start,
        Game,
        Lose
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene((int) Scene.Lose);
    }

    public void LoadGameScene() {
        SceneManager.LoadScene((int) Scene.Game);
    }

    public void LoadStartMenu() {
        GameSession gameSession = FindObjectOfType<GameSession>();
        gameSession.ResetGame();
        SceneManager.LoadScene((int) Scene.Start);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
