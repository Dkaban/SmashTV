/*************************
 * 
 * EnemyMelee.cs
 * 
 * Author: Dustin Kaban
 * Date: August 23rd, 2020
 * 
 * This class handles the functionality of the melee enemy, it is added onto the enemy along with the enemy driver
 * 
 *************************/

using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    public Enemy enemy;
    protected private const int MELEE_ENEMY_HEALTH = 4;
    private void Start()
    {
        this.enemy = this.GetComponent<EnemyDriver>().enemy;
        enemy.SetHealth(MELEE_ENEMY_HEALTH);
    }
    //TODO: Make a proper update, this is just placeholder movement for now.
    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, WorldHandler.Instance.playerObject.transform.position, enemy.GetMovementSpeed() * Time.deltaTime);
        transform.LookAt(WorldHandler.Instance.playerObject.transform);
    }
}
