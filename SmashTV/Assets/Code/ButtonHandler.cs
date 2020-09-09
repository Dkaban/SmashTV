/*************************
 * 
 * ButtonHandler.cs
 * 
 * Author: Dustin Kaban
 * Date: September 9th, 2020
 * 
 * This class handles all button input functions
 * 
 *************************/

using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    //Pauses the time scale.  NOT THE BEST IDEA, but it works for now.
    //TODO: Clean this up.
    public void PressPause()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    //Restarts the scene from scratch
    public void PressRestart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
