/*************************
 * 
 * PlayerBullet.cs
 * 
 * Author: Dustin Kaban
 * Date: August 1st, 2020
 * 
 * This class handles the players bullets specific operations
 * 
 *************************/

public class PlayerBullet : Bullet
{
    public PlayerBullet(UnityEngine.Vector3 dest, float bulletSpeed)
    {
        destination = dest;
        speed = bulletSpeed;
    }

    override
    public void DestroyBullet(UnityEngine.GameObject bulletObject)
    {
        UnityEngine.GameObject.Destroy(bulletObject);
    }
}
