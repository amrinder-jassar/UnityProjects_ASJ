using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Muffin : MonoBehaviour
{
    public int totalMuffins;
    public TMP_Text muffinsText;
    public RectTransform[] spinLights;
    public float[] spinLightSpeeds;
    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    void Update()
    {
        for (int i =0; i < spinLights.Length; i++)
        {
            spinLights[i].Rotate(0f, 0f, spinLightSpeeds[i] * Time.deltaTime);
        }
    }

    private void UpdateUI()
    {
        // Update UI
        muffinsText.text = totalMuffins + "muffins";
    }
    public void OnMuffinClicked()
    {
        // increase the number of muffin collected
        totalMuffins = totalMuffins + 1;
        UpdateUI();
    }
    
}
