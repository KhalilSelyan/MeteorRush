using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject[] asteroid;
    public float spawnTimer = 1.0f;
    public int selected,count;
    public float difficultyRate = 0.75f;
    void Start()
    {
        StartCoroutine(SpawnAsteroid());
    }

    private void createAsteroid()
    {
        selected = Random.Range(0, 4);
        Vector3 spawnPos = new Vector3(20, Random.Range(-30.5f, 13.5f), 0);
        if(selected == 3)// WeirdAsteroid goes up and down so that it doesn't touch the lower and upper bounds we always spawn it in middle
        {
            Instantiate(asteroid[selected], new Vector3(20,0,0), Quaternion.identity);
        }
        else // the other three asteroids are fine wherever they are spawned
        {
            Instantiate(asteroid[selected], spawnPos, Quaternion.identity);
        }
        
    }
    IEnumerator SpawnAsteroid()
    {
        while (true) // an infinite loop to keep spawning forever
        {
            yield return new WaitForSeconds(spawnTimer);
            createAsteroid();
            count++;
            if(count == 15) // after every 15 spawned asteroids the time between each one being spawned gets shorter so the game gets harder
            {
                count = 0;
                spawnTimer = spawnTimer * difficultyRate;
            }
            
        }
    }

}
