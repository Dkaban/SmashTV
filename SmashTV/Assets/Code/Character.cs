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
    private protected Vector3 location;
    private protected int health;
    private protected float speed;
    private protected Rigidbody rigidBody;
    private protected Transform transform;

    public enum CharacterType
    {
        Player,
        Enemy
    }
    protected CharacterType type;

    public abstract int GetHealth();
    public abstract void GainHealth(int amount);
    public abstract void LoseHealth(int amount);
}
