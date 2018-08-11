using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {
    private KeysCounterText kct;
    private void Start()
    {
        kct = GameObject.FindGameObjectWithTag("KeyCounter").GetComponent<KeysCounterText>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Hit");
        if (col.CompareTag("Player"))
        {
            Destroy(gameObject);
            kct.keys += 1;
        }
    }

}
