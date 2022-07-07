using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class MinigameTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] float timeMin;
    [SerializeField] float timeSeg;


    private void Start()
    {
        timeText.text = string.Empty;


    }

    private void Update()
    {
        timeSeg += Time.deltaTime;
        if(timeSeg >= 60)
        {
            timeMin++;
            timeSeg = 0;
        }
        timeText.text = $"{timeMin}:{timeSeg}";
    }


}
