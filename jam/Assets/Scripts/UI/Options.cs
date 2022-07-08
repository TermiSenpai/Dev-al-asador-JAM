using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] Slider audioSlider;

    [SerializeField] private MenuController controller;

    public void onChangeSliderValue()
    {
        source.volume = audioSlider.value;
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
