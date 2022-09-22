using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 45;
    public float resetTimeValue = 47;
    public TextMeshProUGUI timeText;
    private float decimalTimeValue;
    
    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            
        }

        else
        {
            TurnManager.GetInstance().TriggerChangeTurn();
        }
        DisplayTime(timeValue);
    }

    public void TimeResetter()
    {
        timeValue = resetTimeValue;
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        
        timeText.text = timeToDisplay.ToString("##");

    }
}
