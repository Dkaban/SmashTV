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

    public enum CharacterType
    {
        Player,
        Enemy
    }
    protected CharacterType type;

    abstract public void Move(UnityEngine.Rigidbody rb);
    abstract public int CheckHealth();
    abstract public void GainHealth(int amount);
    abstract public void LoseHealth(int amount);
}
