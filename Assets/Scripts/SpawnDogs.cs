using UnityEngine;

public class SpawnDogs : MonoBehaviour
{
    [SerializeField] GameObject dog1;
    [SerializeField] GameObject dog2;
    [SerializeField] GameObject dog3;
    [SerializeField] float maxX;
    [SerializeField] float minX;
    [SerializeField] float maxY;
    [SerializeField] float minY;
    [SerializeField] float timeBetweenSpawn;

    private float spawnTime;
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        float dogRange = Random.Range(1.0f, 10.0f);

        if(dogRange <= 3.33f)
            Instantiate(dog1, new Vector3(randomX, randomY, 0), Quaternion.identity);
        else if (dogRange <= 6.66f)
            Instantiate(dog2, new Vector3(randomX, randomY, 0), Quaternion.identity);
        else
            Instantiate(dog3, new Vector3(randomX, randomY, 0), Quaternion.identity);
    }
}