using UnityEngine;
using TMPro;

public class TimeCounter : MonoBehaviour {

    public TextMeshProUGUI timerText;
    private float startTime;
    private float timePassed;
    private int minutesPassed;
    private int secondsPassed;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        timePassed = Time.time - startTime;
        minutesPassed = ((int) timePassed / 60);
        secondsPassed = ((int)timePassed - (60 * minutesPassed) / 1);
        timerText.text = (minutesPassed + ":" + secondsPassed);
    }
}
