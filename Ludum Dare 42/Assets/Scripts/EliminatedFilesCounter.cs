using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EliminatedFilesCounter : MonoBehaviour {

    public TextMeshProUGUI eliminatedFilesText;
    public int filesEliminated;

	// Use this for initialization
	void Start () {
        filesEliminated = 0;
	}
	
	// Update is called once per frame
	void Update () {
        eliminatedFilesText.text = "Files Eliminated: " + filesEliminated;
	}
}
