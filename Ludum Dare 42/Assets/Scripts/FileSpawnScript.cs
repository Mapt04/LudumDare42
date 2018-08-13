using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSpawnScript : MonoBehaviour {

    public Transform[] spawnPositions;
    public float spawnDelay;
    private GameObject encryptedFileInstance;
    public GameObject encryptedFile;
    public GameObject activeFile;

	// Use this for initialization
	void Start () 
    {
        Spawn();
        InvokeRepeating("Spawn", spawnDelay, spawnDelay - 0.5f);
	}

    public void Spawn () 
    {
        int spawnPositionIndex = Random.Range(0, spawnPositions.Length);
        encryptedFileInstance = Instantiate(encryptedFile, spawnPositions[spawnPositionIndex].position, spawnPositions[spawnPositionIndex].rotation);
    }

	
}
