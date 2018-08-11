using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour {

    public float moveSpeed;
    private float horizontal;
    private float vertical;
    private Vector2 moveVelocity;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        moveVelocity = new Vector2(horizontal, vertical);
        transform.Translate(moveVelocity * moveSpeed * Time.deltaTime);
	}

}
