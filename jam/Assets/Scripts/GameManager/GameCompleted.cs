using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameCompleted : MonoBehaviour
{
    [SerializeField] private Image background;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI exitTxt;

    [SerializeField] private float fadeSpeed;

    private bool canExit = false;


    private void Update()
    {
        if (canExit)
        {
            if(Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public IEnumerator fadeIN()
    {

        for (float i = -0.05f; i <= 1.2f; i += fadeSpeed)
        {

            Color bgOpacity = background.color;
            Color txtOpacity = text.color;
            bgOpacity.a = i;
            txtOpacity.a = i;
            background.color = bgOpacity;

            yield return new WaitForSeconds(0.05f);
            
            text.color = txtOpacity;

        }

        for (float i = -0.05f; i <= 1.2f; i += fadeSpeed)
        {

            Color exitOpacity = exitTxt.color;
            exitOpacity.a = i;
            exitTxt.color = exitOpacity;

            yield return new WaitForSeconds(0.05f);

            exitTxt.color = exitOpacity;

        }

        canExit = true;

    }
}
