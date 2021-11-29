using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class openKeyboard : InputField
{
    private  UnityEngine.TouchScreenKeyboard keyboard;
    public static string inputText = "";

    // Start is called before the first frame update
    public override void OnSelect(BaseEventData eventData)
    {
        keyboard = TouchScreenKeyboard.Open("",TouchScreenKeyboardType.Default);
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard != null)
            inputText = keyboard.text;
    }
}
