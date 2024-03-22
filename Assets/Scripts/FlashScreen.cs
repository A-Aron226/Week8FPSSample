using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashScreen : MonoBehaviour
{
    [SerializeField] Color targetColor;
    [SerializeField] Image flashImage;
    [SerializeField] float flashSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var currentColor = flashImage.color;

        currentColor = Color.Lerp(currentColor, targetColor, flashSpeed * Time.deltaTime);

        flashImage.color = currentColor;

        flashImage.enabled = false;
    }

    [ContextMenu("Set Red")]
    [ContextMenu("Set Transparent")] //testing purposes
    public void SetTargetTransparent()
    {
        targetColor = Color.red;
        targetColor.a = 0;
        
    }

    public void SetTargetColor()
    {
        flashImage.enabled = true;
        targetColor = Color.red;
    }
}
