using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherespawner : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canSpawn = true; 

    public GameObject SpheresPrefab; 
    public List<Transform> SpawnPositions = new List<Transform>(); 
    public float timeBetweenSpawns; 
    private List<GameObject> sheepList = new List<GameObject>(); 

    void Start()
    {
        StartCoroutine(SpawnRoutine());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnSheep()
    {
        Vector3 randomPosition = SpawnPositions[Random.Range(0, SpawnPositions.Count)].position; // 1
        GameObject Spheres = Instantiate(SpheresPrefab, randomPosition, SpheresPrefab.transform.rotation); // 2
        sheepList.Add(Spheres); // 3
        Spheres.GetComponent<Spheres>().SetSpawner(this); // 4
    }
    private IEnumerator SpawnRoutine() // 1
    {
        while (canSpawn) // 2
        {
            SpawnSheep(); // 3
            yield return new WaitForSeconds(timeBetweenSpawns); // 4
        }
    }
    public void RemoveSheepFromList(GameObject Spheres)
    {
        sheepList.Remove(Spheres);
    }
    public void DestroyAllSheep()
    {
        foreach (GameObject Spheres in sheepList) // 1
        {
            Destroy(Spheres); // 2
        }

        sheepList.Clear();
    }



}
