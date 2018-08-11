using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {
    public float growSpeed;
    Vector3 scale;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scale = transform.localScale;
        scale.x += growSpeed * Time.deltaTime;
        scale.y += growSpeed * Time.deltaTime;
        transform.localScale = scale;
	}
}
