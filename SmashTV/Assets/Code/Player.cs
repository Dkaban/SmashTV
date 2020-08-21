/*************************
 * 
 * Player.cs
 * 
 * Author: Dustin Kaban
 * Date: July 29th, 2020
 * 
 * This class handles the Player and it's base functionality
 * 
 *************************/

using UnityEngine;

public class Player : Character
{
    public Player(Vector3 startingLoc, CharacterType charType, float speed)
    {
        this.location = startingLoc;
        this.type = charType;
        this.speed = speed;
        this.health = 10;
    }

    public void Move(Rigidbody rb)
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal")*this.speed, 0.0f, Input.GetAxis("Vertical")*this.speed);
    }

    public void LookTowards(Vector3 target)
    {
        this.transform.LookAt(target);
    }

    public override int GetHealth()
    {
        return this.health;
    }

    public override void GainHealth(int amount)
    {
        this.health += amount;
    }

    public override void LoseHealth(int amount)
    {
        this.health -= amount;
        UIHandler.Instance.SetHealth(this.health);
    }

    public void SetTransform(Transform t)
    {
        this.transform = t;
    }
}
