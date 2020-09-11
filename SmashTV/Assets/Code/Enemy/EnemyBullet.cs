/*************************
 * 
 * EnemyMelee.cs
 * 
 * Author: Dustin Kaban
 * Date: August 24th, 2020
 * 
 * This class handles the functionality of the enemy bullet.  A basic bullet for now.
 * 
 *************************/

using System.Collections;
using UnityEngine;

public class EnemyBullet : Bullet
{
    private const float BULLET_SPEED = 10.0f;
    private const int BULLET_DAMAGE = 1;

    public override void Initialize(Vector3 target, Transform spawnTransform)
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //other.GetComponent<EnemyDriver>().enemy.LoseHealth(BULLET_DAMAGE);
            other.GetComponent<PlayerDriver>().player.LoseHealth(BULLET_DAMAGE);
            DestroyBullet();
        }
    }

    public override void DestroyBullet()
    {
        StopCoroutine("WaitAndDestroy");
        Destroy(gameObject);
    }
}
