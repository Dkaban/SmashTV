﻿/*************************
 * 
 * Enemy.cs
 * 
 * Author: Dustin Kaban
 * Date: August 18th, 2020
 * 
 * This class handles the Enemy base functionality
 * 
 *************************/

using UnityEngine;

public class Enemy : Character
{
    //protected readonly int MAX_HEALTH = 4;
    public readonly int COLLISION_DAMAGE = 1;

    public enum EnemyType
    {
        Melee,
        Shooter
    }

    public Enemy(Vector3 spawnLocation, Transform enemyTransform, float movementSpeed)
    {
        //health = MAX_HEALTH;
        location = spawnLocation;
        transform = enemyTransform;
        speed = movementSpeed;
    }

    public override int GetHealth()
    {
        return health;
    }

    public override void LoseHealth(int amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Death();
        }
    }

    public override void GainHealth(int amount)
    {
        health += amount;
    }

    public void SetHealth(int amount)
    {
        health = amount;
    }

    public float GetMovementSpeed()
    {
        return speed;
    }

    private void Death()
    {
        //Need to remove this from the EnemySpawner enemyObjectList as well.
        transform.GetComponent<EnemyDriver>().enemySpawner.RemoveFromList(transform.gameObject);
        Object.Destroy(transform.gameObject);
    }
}