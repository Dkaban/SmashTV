/*************************
 * 
 * Character.cs
 * 
 * Author: Dustin Kaban
 * Date: July 29th, 2020
 * 
 * This is the abstract class that holds all the base information for all characters
 * 
 *************************/

using UnityEngine;

public abstract class Character
{
    protected Vector3 location;
    protected int health;
    protected float speed;
    protected Rigidbody rigidBody;
    protected Transform transform;

    public enum CharacterType
    {
        Player,
        Enemy
    }
    protected CharacterType type;

    public abstract int CheckHealth();
    public abstract void GainHealth(int amount);
    public abstract void LoseHealth(int amount);
}
