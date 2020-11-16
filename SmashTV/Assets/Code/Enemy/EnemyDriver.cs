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
    public EnemyType enemyType;

    private void Awake()
    {
        enemy = new Enemy(4,Vector3.zero, transform, 2.0f,1,1);
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
