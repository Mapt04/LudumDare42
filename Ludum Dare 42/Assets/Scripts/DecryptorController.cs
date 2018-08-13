using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecryptorController : MonoBehaviour {

    public Transform DecryptorAppSpawn;
    public Transform canvas;
    public GameObject[] decryptorApps;
    private int decryptorApp;
    public bool isDecrypting;
    private GameObject decryptorAppInstance;

	// Use this for initialization
	void Start () 
    {
        isDecrypting = false;
	}
	
	// Update is called once per frame
    public void Spawn() 
    {
        decryptorApp = Random.Range(0, decryptorApps.Length);
        decryptorAppInstance = Instantiate(decryptorApps[decryptorApp], DecryptorAppSpawn.position, DecryptorAppSpawn.rotation);
        decryptorAppInstance.transform.SetParent(canvas);
        isDecrypting = true;
    }

   public void Delete () 
    {
        isDecrypting = false;
        Destroy(decryptorAppInstance);
    }

    private void Update()
    {

    }
}
