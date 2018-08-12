using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSpawnScript : MonoBehaviour {

    public Transform[] spawnPositions;
    public float spawnDelay;
    public GameObject encryptedFile;
    private GameObject encryptedFileInstance;
    public GameObject canvas;
    public Transform decryptorAppSpawn;
    public EncryptedFileScript encryptedFileScript;

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
        encryptedFileInstance.transform.SetParent(canvas.transform);
        encryptedFileInstance.transform.position = spawnPositions[spawnPositionIndex].position;
    }
	
}
