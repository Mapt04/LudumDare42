using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void Lose()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void Play()
    {
        SceneManager.LoadScene("Main");
        FindObjectOfType<EliminatedFilesCounter>();
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
}
