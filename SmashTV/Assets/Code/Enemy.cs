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

public class Enemy : Character
{
    protected readonly int MAX_HEALTH = 4;

    public Enemy(Vector3 spawnLocation, Transform enemyTransform, float movementSpeed)
    {
        this.health = MAX_HEALTH;
        this.location = spawnLocation;
        this.transform = enemyTransform;
        this.speed = movementSpeed;
    }

    public override int CheckHealth()
    {
        return this.health;
    }

    public override void LoseHealth(int amount)
    {
        this.health -= amount;

        if(this.health <= 0)
        {
            Death();
        }
    }

    public override void GainHealth(int amount)
    {
        this.health += amount;
    }

    public float GetMovementSpeed()
    {
        return this.speed;
    }

    private void Death()
    {
        //Need to remove this from the EnemySpawner enemyObjectList as well.
        transform.GetComponent<EnemyDriver>().enemySpawner.RemoveFromList(transform.gameObject);
        Object.Destroy(this.transform.gameObject);
    }
}
