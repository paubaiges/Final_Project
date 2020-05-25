using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public bool canSpawn = true; // 1
	public GameObject enemyPrefab; // 2
	public List<Transform> enemySpawnPositions = new List<Transform>(); // 3
	public float timeBetweenSpawns; // 4
	private List<GameObject> enemyList = new List<GameObject>(); // 5


	void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

   private void Spawnenemy()
	{
	    Vector3 randomPosition = enemySpawnPositions[Random.Range(0, enemySpawnPositions.Count)].position; // 1
	    GameObject enemy = Instantiate(enemyPrefab, randomPosition, enemyPrefab.transform.rotation); // 2
	    enemyList.Add(enemy); // 3
	    enemy.GetComponent<enemy>().SetSpawner(this); // 4
	}


	private IEnumerator SpawnRoutine() // 1
	{
	    while (canSpawn) // 2
	    {
	        Spawnenemy(); // 3
	        yield return new WaitForSeconds(timeBetweenSpawns); // 4
	    }
	}

	public void RemoveenemyFromList(GameObject enemy)
	{
	    enemyList.Remove(enemy);
	}
	public void DestroyAllEnemies()
	{
		foreach (GameObject enemy in enemyList)
		{
			Destroy(enemy);
		}

		enemyList.Clear();
	}
}

