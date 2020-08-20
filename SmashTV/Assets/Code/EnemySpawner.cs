/*************************
 * 
 * EnemySpawner.cs
 * 
 * Author: Dustin Kaban
 * Date: August 19th, 2020
 * 
 * This class handles spawning of enemies and tracking them via a list
 * 
 *************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefabObject;
    protected private const int ENEMY_COUNT_TO_SPAWN = 3;
    public List<GameObject> enemyObjectList = new List<GameObject>();
    protected private const float SPAWN_DELAY = 2.5f;
    private WorldHandler worldHandler;
    private bool spawnerRunning = false;

    private void Start()
    {
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while (enemyObjectList.Count < ENEMY_COUNT_TO_SPAWN)
        {
            yield return new WaitForSeconds(SPAWN_DELAY);
            spawnerRunning = true;
            GameObject enemyObject = Instantiate(enemyPrefabObject) as GameObject;
            enemyObject.GetComponent<EnemyDriver>().enemySpawner = this;
            enemyObjectList.Add(enemyObject);
        }
        spawnerRunning = false;
        StopCoroutine("SpawnEnemy");
    }

    public void RemoveFromList(GameObject enemyObjectToRemove)
    {
        enemyObjectList.Remove(enemyObjectToRemove);

        if(!spawnerRunning)
        {
            StartCoroutine("SpawnEnemy");
        }
    }
}
