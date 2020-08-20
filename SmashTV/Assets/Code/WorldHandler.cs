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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldHandler : MonoBehaviour
{
    #region SINGLETON SETUP
    public static WorldHandler Instance { get;  set; }
    private void Awake()
    {
        Instance = this;
    }
    #endregion
    public GameObject playerObject;
}
