using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public float timeBetweenWaves = 5f;
    public float timeToSpawn = 2f;
    public float spawnCount = 0f;

    
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            spawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
            spawnCount++;
            Debug.Log(spawnCount);
            if (spawnCount >= 10)
            {
                Destroy(this);
            }
        }
    }
    
    void spawnBlocks()
    {
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }

            
        }
}
