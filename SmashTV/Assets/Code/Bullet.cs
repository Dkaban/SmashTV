/*************************
 * 
 * Bullet.cs
 * 
 * Author: Dustin Kaban
 * Date: August 1st, 2020
 * 
 * This is an abstract class to control how bullets are set up and used
 * 
 *************************/

using UnityEngine;

public abstract class Bullet
{
    protected Vector3 destination;
    protected float speed;

    public abstract void DestroyBullet(GameObject bulletObject);
}
