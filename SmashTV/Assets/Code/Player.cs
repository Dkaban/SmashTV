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

    override
    public void Move(Rigidbody rb)
    {
        rb.velocity = new UnityEngine.Vector3(Input.GetAxis("Horizontal")*this.speed, 0.0f, Input.GetAxis("Vertical")*this.speed);
    }

    override
    public void LookTowards(UnityEngine.Vector3 target)
    {
        transform.LookAt(target);
    }

    override
    public int CheckHealth()
    {
        return 0;
    }

    override
    public void GainHealth(int amount)
    {
        this.health += amount;
    }

    override
    public void LoseHealth(int amount)
    {
        this.health -= amount;
    }

    public void SetTransform(Transform t)
    {
        this.transform = t;
    }
}
