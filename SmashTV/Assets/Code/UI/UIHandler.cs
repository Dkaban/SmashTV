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

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public static UIHandler Instance { get; private set; }

    public Slider playerHealthSlider;
    public Text timerText;
    private int _timer;

    public Text pointText;
    private int _points;

    public Text levelText;

    private void Awake()
    {
        Instance = this;
        //Initialize the Timer to start counting the time the player is alive.
        StartCoroutine(AliveTimer());
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

    public void SetLevel(int amount)
    {
        levelText.text = "Level " + amount;
    }

    private IEnumerator AliveTimer()
    {
        while(WorldHandler.Instance.playerObject.GetComponent<PlayerDriver>().player.GetHealth() > 0)
        {
            yield return new WaitForSeconds(1.0f);
            _timer += 1;
            timerText.text = _timer + " s";
        }

        StopCoroutine(AliveTimer());
    }

    public void AddPoints(int amount)
    {
        _points += amount;
        pointText.text = _points + " Point(s)";
    }
}
