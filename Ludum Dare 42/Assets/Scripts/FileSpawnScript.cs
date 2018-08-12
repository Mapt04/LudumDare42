using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSpawnScript : MonoBehaviour {

    public Transform[] spawnPositions;
    public float spawnDelay;
    private GameObject encryptedFileInstance;
    public GameObject encryptedFile;

	// Use this for initialization
	void Start () 
    {
        Spawn();
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
	}

    void Spawn () 
    {
        int spawnPositionIndex = Random.Range(0, spawnPositions.Length);
        encryptedFileInstance = Instantiate(encryptedFile, spawnPositions[spawnPositionIndex].position, spawnPositions[spawnPositionIndex].rotation);
    }
	
}
