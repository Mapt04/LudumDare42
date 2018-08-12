using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageManager : MonoBehaviour {

    public float storageCapacity;
    public float storageOccupied;
	// Use this for initialization

    private void Update()
    {
        if (storageOccupied >= storageCapacity)
        {
            FindObjectOfType<GameManager>().Lose();
        }
    }
}
