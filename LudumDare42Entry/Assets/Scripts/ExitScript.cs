using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour {

    public int requiredKeys;
    private KeysCounterText kct;
	// Use this for initialization
	void Start () {
        kct = GameObject.FindGameObjectWithTag("KeyCounter").GetComponent<KeysCounterText>();
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            if(kct.keys == requiredKeys)
            {
                FindObjectOfType<GameManager>().WinGame();
            }
        }
    }
}
