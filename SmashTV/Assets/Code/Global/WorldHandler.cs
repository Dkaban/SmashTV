/*************************
 * 
 * WorldHandler.cs
 * 
 * Author: Dustin Kaban
 * Date: August 19th, 2020
 * 
 * This class handles things that need to be accessible globally
 * 
 *************************/

using UnityEngine;

public class WorldHandler : MonoBehaviour
{
    public static WorldHandler Instance { get; private set; }
    public GameObject playerObject;

    private void Awake()
    {
        Instance = this;
    }
}
