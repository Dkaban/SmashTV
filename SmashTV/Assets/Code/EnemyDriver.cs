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
        enemy = new Enemy(Vector3.zero, this.transform, 2.0f);
    }

    //TODO: Make a proper update, this is just placeholder movement for now.
    private void FixedUpdate()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, WorldHandler.Instance.playerObject.transform.position, enemy.GetMovementSpeed() * Time.deltaTime);
        this.transform.LookAt(WorldHandler.Instance.playerObject.transform);
    }

}
