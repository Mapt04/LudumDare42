using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EliminatedFilesCounter : MonoBehaviour {

    public TextMeshProUGUI eliminatedFilesText;
    public int filesEliminated = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        eliminatedFilesText.text = "Files Eliminated: " + filesEliminated;
	}

}
