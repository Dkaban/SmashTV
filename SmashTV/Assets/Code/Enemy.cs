/*************************
 * 
 * Enemy.cs
 * 
 * Author: Dustin Kaban
 * Date: August 18th, 2020
 * 
 * This class handles the Enemy base functionality
 * 
 *************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    protected readonly int MAX_HEALTH = 10;
    public Enemy(Vector3 spawnLocation)
    {
        this.health = MAX_HEALTH;
        this.location = spawnLocation;
    }

    public override int CheckHealth()
    {
        return this.health;
    }

    public override void LoseHealth(int amount)
    {
        this.health -= amount;
    }

    public override void GainHealth(int amount)
    {
        this.health += amount;
    }

    public override void LookTowards(Vector3 target)
    {

    }

    public override void Move(Rigidbody rb)
    {

    }
}
