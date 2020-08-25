/*************************
 * 
 * EnemyMelee.cs
 * 
 * Author: Dustin Kaban
 * Date: August 24th, 2020
 * 
 * This class handles the functionality of the shooter enemy.  Added along side EnemyDriver.cs
 * 
 *************************/

using System.Collections;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public Enemy enemy;
    protected private const float DISTANCE_FROM_PLAYER = 5.0f;
    protected private const int SHOOTER_ENEMY_HEALTH = 2;
    protected private const float SHOOT_DELAY = 2.0f;
    public GameObject BulletObjectPrefab;

    private void Start()
    {
        enemy = this.GetComponent<EnemyDriver>().enemy;
        enemy.SetHealth(SHOOTER_ENEMY_HEALTH);

        StartCoroutine("Shoot");
    }

    private void FixedUpdate()
    {
        if(Vector3.Distance(transform.position,WorldHandler.Instance.playerObject.transform.position) > DISTANCE_FROM_PLAYER)
        {
            transform.position = Vector3.MoveTowards(transform.position, WorldHandler.Instance.playerObject.transform.position, enemy.GetMovementSpeed() * Time.deltaTime);
        }
        transform.LookAt(WorldHandler.Instance.playerObject.transform);
    }

    private IEnumerator Shoot()
    {
        while(this.gameObject.activeSelf)
        {
            yield return new WaitForSeconds(SHOOT_DELAY);
            GameObject bulletGO = GameObject.Instantiate(BulletObjectPrefab);
            bulletGO.GetComponent<EnemyBullet>().Initialize(WorldHandler.Instance.playerObject.transform.position, transform);
        }
    }
}
