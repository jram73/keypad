using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript1 : MonoBehaviour
{
    public int keypadNumber = 1;

    public UnityEvent KeypadClicked;


    private void OnMouseDown()
    {
        KeypadClicked.Invoke();
    }
}
