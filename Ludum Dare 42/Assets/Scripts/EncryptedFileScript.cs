using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncryptedFileScript : MonoBehaviour {

    public float weight;
    public GameObject[] decryptorApps;
    private Transform decryptorAppSpawn;
    private int decryptorAppIndex;
    public GameObject decryptorApp;

	// Use this for initialization
	void Start () 
    {
        weight = Random.Range(5, 15);
        FindObjectOfType<StorageManager>().storageOccupied += weight;
        decryptorAppSpawn = transform;
        decryptorAppSpawn.position = new Vector3(336f, 300, 0);
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    public void SpawnDecryptorApp () 
    {
        decryptorAppIndex = Random.Range((int)0, decryptorApps.Length);
        decryptorApp = decryptorApps[decryptorAppIndex];
        decryptorApp = Instantiate(decryptorApps[decryptorAppIndex], decryptorAppSpawn);

    }
}
