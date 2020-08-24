using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public Enemy enemy;
    protected private const float DISTANCE_FROM_PLAYER = 5.0f;
    protected private const int SHOOTER_ENEMY_HEALTH = 2;

    private void Start()
    {
        enemy = this.GetComponent<EnemyDriver>().enemy;
        enemy.SetHealth(SHOOTER_ENEMY_HEALTH);
    }

    private void FixedUpdate()
    {
        if(Vector3.Distance(transform.position,WorldHandler.Instance.playerObject.transform.position) > DISTANCE_FROM_PLAYER)
        {
            transform.position = Vector3.MoveTowards(transform.position, WorldHandler.Instance.playerObject.transform.position, enemy.GetMovementSpeed() * Time.deltaTime);
        }
        transform.LookAt(WorldHandler.Instance.playerObject.transform);

        //TODO: MAKE THE ENEMY SHOOT!!
    }
}
