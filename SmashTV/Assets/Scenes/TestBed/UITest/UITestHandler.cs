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
using UnityEngine;
using UnityEngine.UI;

public class UITestHandler : MonoBehaviour
{
    public Transform GridParent;
    public GameObject ButtonObject;
    protected private Boolean _darkMode = false;

    private void Start()
    {
        AddButtons(9);
    }

    private void AddButtons(int buttonCount)
    {
        for(int i=1;i<=buttonCount;i++)
        {
            var buttonObject = Instantiate(ButtonObject) as GameObject;
            Button button = buttonObject.GetComponent<Button>();
            button.GetComponentInChildren<Text>().text = i.ToString();
            buttonObject.transform.SetParent(GridParent,false);
        }
    }

    public void SetDarkMode()
    {
        switch(_darkMode)
        {
            case true:
                Camera.main.backgroundColor = new Color(255, 255, 255, 255);
                _darkMode = false;
                break;

            case false:
                Camera.main.backgroundColor = new Color(0,0,0,0);
                _darkMode = true;
                break;

            default:
                break;
        }
    }
}
