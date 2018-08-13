using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    private Vector3 movementDirection;
    public float movementSpeed;
    public Transform characterSpawn;
    public Transform characterTransform;

	// Use this for initialization
	void Start () {
        movementDirection = new Vector3(1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.W)))
        {
            movementDirection = new Vector3(0, 1, 0);
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow)) || (Input.GetKeyDown(KeyCode.S)))
        {
            movementDirection = new Vector3(0, -1, 0);
        }
        else if ((Input.GetKeyDown(KeyCode.LeftArrow)) || (Input.GetKeyDown(KeyCode.A)))
        {
            movementDirection = new Vector3(-1, 0, 0);
        }
        else if ((Input.GetKeyDown(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.D)))
        {
            movementDirection = new Vector3(1, 0, 0);
        }
        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
	}

    private void ResetCharacter() 
    {
        characterTransform.position = characterSpawn.position;
        movementDirection = new Vector3(1, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("PathWall"))
        {
            ResetCharacter();
        }

        else if (col.CompareTag("Exit")) 
        {
            FindObjectOfType<DecryptorController>().Delete();
            FindObjectOfType<StorageManager>().storageOccupied -= FindObjectOfType<EncryptedFileScript>().weight;
            Destroy(FindObjectOfType<FileSpawnScript>().activeFile);
            FindObjectOfType<EliminatedFilesCounter>().filesEliminated += 1;

                                           
        }
    }
}