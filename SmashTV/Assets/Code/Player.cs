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
using System;
using System.Numerics;
using UnityEngine;

public class Player : Character
{
    public Player(UnityEngine.Vector3 startingLoc, CharacterType charType, float speed)
    {
        this.location = startingLoc;
        this.type = charType;
        this.speed = speed;
    }

    public override void Move(Rigidbody rb)
    {
        rb.velocity = new UnityEngine.Vector3(Input.GetAxis("Horizontal")*this.speed, 0.0f, Input.GetAxis("Vertical")*this.speed);
    }

    public override void LookTowards(UnityEngine.Vector3 target)
    {
        transform.LookAt(target);
    }

    public override int CheckHealth()
    {
        return 0;
    }

    public override void GainHealth(int amount)
    {
        this.health += amount;
    }

    public override void LoseHealth(int amount)
    {
        this.health -= amount;
    }

    public void SetTransform(Transform t)
    {
        this.transform = t;
    }
}
