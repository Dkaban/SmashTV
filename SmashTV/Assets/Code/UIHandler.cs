/*************************
 * 
 * UIHandler.cs
 * 
 * Author: Dustin Kaban
 * Date: August 19th, 2020
 * 
 * This class handles all of the main UI happenings in the main game scene
 * 
 *************************/

using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public static UIHandler Instance { get; private set; }

    public Slider playerHealthSlider;

    private void Awake()
    {
        Instance = this;
    }

    public void InitializePlayerUI(int maxHealthAmount)
    {
        playerHealthSlider.maxValue = 10;
        playerHealthSlider.value = maxHealthAmount;
    }

    public void SetHealth(int amount)
    {
        playerHealthSlider.value = amount;
    }
}
