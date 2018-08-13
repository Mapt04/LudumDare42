using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StorageCounter : MonoBehaviour {
    public TextMeshProUGUI storageCounter;
    private float storageOccupied;
    private float storageCapacity;
    private float storageAvailable;
    public Image storageBar;

    private void Start()
    {
        storageCounter.text = (" ");
    }

    private void Update()
    {
        storageOccupied = FindObjectOfType<StorageManager>().storageOccupied;
        storageCapacity = FindObjectOfType<StorageManager>().storageCapacity;
        storageAvailable = storageCapacity - storageOccupied;
        storageCounter.text = (storageAvailable - (storageAvailable % 0.1) + "GB available of " + storageCapacity + "GB");
        storageBar.fillAmount = storageOccupied / storageCapacity;
    }
}
