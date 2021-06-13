using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    private int counter;
    public void OnButtonClicked()
    {
        counter = counter + 1;
        Debug.Log(counter);
    }
}
