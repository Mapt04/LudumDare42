using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public void LoseGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            SceneManager.LoadScene("GameOver");
        }
    }

    public void WinGame()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
}
