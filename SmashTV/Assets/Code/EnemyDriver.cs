/*************************
 * 
 * EnemyDriver.cs
 * 
 * Author: Dustin Kaban
 * Date: August 18th, 2020
 * 
 * This class handles specific Mono functions of an enemy
 * 
 *************************/

using UnityEngine;

public class EnemyDriver : MonoBehaviour
{
    public EnemySpawner enemySpawner;
    public Enemy enemy;

    void Awake()
    {
        enemy = new Enemy(Vector3.zero, transform, 2.0f);
    }

    //TODO: Make a proper update, this is just placeholder movement for now.
    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, WorldHandler.Instance.playerObject.transform.position, enemy.GetMovementSpeed() * Time.deltaTime);
        transform.LookAt(WorldHandler.Instance.playerObject.transform);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            WorldHandler.Instance.playerObject.GetComponent<PlayerDriver>().player.LoseHealth(enemy.COLLISION_DAMAGE);
            enemy.LoseHealth(enemy.GetHealth());
        }
    }

}
