using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField] private AudioSource[] sources;
    [SerializeField] Slider audioSlider;

    [SerializeField] private MenuController controller;

    public void onChangeSliderValue()
    {
        for(int i = 0; i < sources.Length - 1; i++)
            sources[i].volume = audioSlider.value;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            audioSlider.value -= 0.1f;

        if (Input.GetKeyDown(KeyCode.RightArrow))
            audioSlider.value += 0.1f;

        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
            controller.openMainMenu();

    }
}
