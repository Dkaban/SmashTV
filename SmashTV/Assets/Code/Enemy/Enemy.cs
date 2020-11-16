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

using UnityEngine;

public enum EnemyType
{
    Melee,
    Shooter
}

public class Enemy : Character
{
    public readonly int COLLISION_DAMAGE = 1;
    private readonly int experienceValue = 1;

    public Enemy(int baseHealth, Vector3 spawnLocation, Transform enemyTransform, float movementSpeed, int baseExperience, int baseLevel)
    {
        health = baseHealth;
        location = spawnLocation;
        transform = enemyTransform;
        speed = movementSpeed;
        experienceValue = baseExperience;
        level = baseLevel;
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
        //Point amount to alot should be generic
        UIHandler.Instance.AddPoints(1);

        //Increase the players Experience
        WorldHandler.Instance.playerDriver.SetExperience(experienceValue);

        //Need to remove this from the EnemySpawner enemyObjectList as well.
        transform.GetComponent<EnemyDriver>().enemySpawner.RemoveFromList(transform.gameObject);

        //Destroy the Enemy Object
        Object.Destroy(transform.gameObject);
    }
}
