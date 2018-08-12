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
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void DeleteFile() 
    {
        Debug.Log("Deleting File");
        EncryptedFileScript encryptedFile = FindObjectOfType<EncryptedFileScript>();
        FindObjectOfType<StorageManager>().storageOccupied -= encryptedFile.weight;
        Destroy(encryptedFile);
    }
}
