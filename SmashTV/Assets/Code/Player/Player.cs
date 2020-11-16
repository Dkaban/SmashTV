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
using UnityEngine;
using UnityEngine.Events;

public class Player : Character
{
    //To help keep track of when the player levels up
    private UnityEvent levelUpEvent = new UnityEvent();

    public Player(Vector3 startingLoc, CharacterType charType, float speed, int health, int experience, int level)
    {
        this.location = startingLoc;
        this.type = charType;
        this.speed = speed;
        this.health = health;
        this.experience = experience;
        this.level = level;
        levelUpEvent.AddListener(CheckForLevelUp);
    }

    private void CheckForLevelUp()
    {
        //TODO: Create a scaling experience required system.
        //Current System: Each level requires 2n experience (n being the users current level)
        if(this.experience >= (2*level))
        {
            //Level Up
            this.level++;
            //Reset experience to 0
            this.experience = 0;
            //Update the UI
            UIHandler.Instance.SetLevel(this.level);
        }
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

    public int GetExperience()
    {
        return this.experience;
    }

    public void SetExperience(int amount)
    {
        this.experience += amount;

        //We need to check for a Level Up
        levelUpEvent.Invoke();
    }

    public void SetTransform(Transform t)
    {
        this.transform = t;
    }
}
