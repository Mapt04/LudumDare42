using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncryptedFileScript : MonoBehaviour {

    public float weight;
    private Transform decryptorAppSpawn;
    public GameObject decryptorApp;


	// Use this for initialization
	void Start () 
    {
        weight = Random.Range(5, 15);
        FindObjectOfType<StorageManager>().storageOccupied += weight;
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    private void OnMouseDown()
    {
        if (!FindObjectOfType<DecryptorController>().isDecrypting) 
        {
            FindObjectOfType<DecryptorController>().Spawn();
            FindObjectOfType<FileSpawnScript>().activeFile = gameObject;
        }

    }

}
