/*************************
 * 
 * UITestHandler.cs
 * 
 * Author: Dustin Kaban
 * Date: September 10th, 2020
 * 
 * This class is a test bed for UI functionality to be added to the game.
 * 
 *************************/

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UITestHandler : MonoBehaviour
{
    public Transform GridParent;
    public GameObject ButtonObject;
    protected private Boolean _nightMode = false;
    protected private int _inputValue = 0;
    public Text InputText;

    private void Start()
    {
        AddButtons(9);
    }

    //Create all the buttons for the menu
    private void AddButtons(int buttonCount)
    {
        for(int i=1;i<=buttonCount;i++)
        {
            var buttonObject = Instantiate(ButtonObject) as GameObject;
            Button button = buttonObject.GetComponent<Button>();
            button.GetComponentInChildren<Text>().text = i.ToString();
            buttonObject.transform.SetParent(GridParent,false);
            ButtonAddListener(button, i);
        }
    }

    //Toggle between night mode and regular mode
    public void SetNightMode()
    {
        switch(_nightMode)
        {
            case true:
                Camera.main.backgroundColor = new Color(255, 255, 255, 255);
                _nightMode = false;
                break;

            case false:
                Camera.main.backgroundColor = new Color(0,0,0,0);
                _nightMode = true;
                break;

            default:
                break;
        }
    }

    //Add the listener to each button, this has to be done here and not inside the loop
    //If done inside the loop, listener takes the last value passed.
    void ButtonAddListener(Button button, int i)
    {
        button.onClick.AddListener(() => NumberPressAction(i));
    }

    void NumberPressAction(int value)
    {
        UpdateInputValue(value);
    }

    private void UpdateInputValue(int value)
    {
        _inputValue = value;
        InputText.text = _inputValue.ToString();
    }
}
