/*************************
 * 
 * PlayerDriver.cs
 * 
 * Author: Dustin Kaban
 * Date: July 29th, 2020
 * 
 * This class handles the Player and it's base functionality
 * 
 *************************/

using UnityEngine;

public class PlayerDriver : MonoBehaviour
{
    public Player player = new Player(Vector3.zero, Character.CharacterType.Player, 5.0f);
    private Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        player.Move(rigidBody);
    }
}
