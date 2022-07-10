using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class text : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI changeableText;
    [SerializeField] Color perfectColor;
    [SerializeField] Color goodColor;
    [SerializeField] Color failColor;
    // Start is called before the first frame update
    void Start()
    {
        changeableText.text = string.Empty;
        changeableText.enableVertexGradient = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perfect"))
        {
            Debug.Log("Perfect");
            changeableText.text = "perfect";
            changeableText.colorGradient = new TMPro.VertexGradient(perfectColor, goodColor,perfectColor,goodColor);
        }

        if (collision.CompareTag("Good"))
        {
            Debug.Log("Good");
            changeableText.text = "good";
            changeableText.colorGradient = new TMPro.VertexGradient(goodColor, goodColor,goodColor,goodColor);
        }

        if (collision.CompareTag("Lose"))
        {
            Debug.Log("Lose");
            changeableText.text = "failed";
            changeableText.colorGradient = new TMPro.VertexGradient(failColor, failColor,failColor,failColor);
        }
    }
}
