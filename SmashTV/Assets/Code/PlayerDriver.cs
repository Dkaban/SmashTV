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

    //Variables for Mouse
    private Vector3 mouseScreenPosition;
    private Vector3 mouseWorldSpace;

    private void Awake()
    {
        player.SetTransform(transform);
        rigidBody = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        player.Move(rigidBody);
        UpdateMousePosition();
        player.LookTowards(mouseWorldSpace);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }

    private void UpdateMousePosition()
    {
        mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = 50;
        mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        mouseWorldSpace.y = 0;
    }
}
