/*************************
 * 
 * Bullet.cs
 * 
 * Author: Dustin Kaban
 * Date: August 2nd, 2020
 * 
 * This is an abstract class to control how bullets are set up and used
 * 
 *************************/

using System.Collections;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    public abstract void Initialize(Vector3 target, Transform spawnTransform);
    public abstract void DestroyBullet();
}
