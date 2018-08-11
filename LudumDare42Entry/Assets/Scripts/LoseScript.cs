using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("BlackHole"))
        {
            FindObjectOfType<GameManager>().LoseGame();
        }
    }
}
