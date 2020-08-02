/*************************
 * 
 * PlayerBullet.cs
 * 
 * Author: Dustin Kaban
 * Date: August 2nd, 2020
 * 
 * This class handles the players bullets specific operations
 * 
 *************************/

using System.Collections;
using UnityEngine;

public class PlayerBullet : Bullet
{
    private const float BULLET_SPEED = 10.0f;
    override
    public void Initialize(Vector3 target, Transform spawnTransform)
    {
        transform.position = spawnTransform.position;
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 moveDirection = (target - spawnTransform.position).normalized * BULLET_SPEED;
        rb.velocity = new Vector3(moveDirection.x, 0, moveDirection.z);//0.5f on the Y so it's at the middle of the player

        StartCoroutine("WaitAndDestroy");
    }

    private IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(1.0f);
        DestroyBullet();
    }

    override
    public void DestroyBullet()
    {
        StopCoroutine("WaitAndDestroy");
        Destroy(gameObject);
    }
}
