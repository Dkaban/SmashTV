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

using UnityEngine;
using UnityEngine.UI;

public class UITestHandler : MonoBehaviour
{
    public Transform GridParent;
    public GameObject ButtonObject;

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
}
