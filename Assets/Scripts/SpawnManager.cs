using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 25;
    public float spawnPosZ = 30;
    private float startDelay = 1.5f;
    private float repeatRate = 1.2f;
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatRate);
    }
    private void Update()
    {

    }
    private void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
