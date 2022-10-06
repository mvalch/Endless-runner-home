using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Obstacle;

    public float timeBtwSpawn;
    public float startTimeBtwSpawn;

    private void Update()
    {
        if (timeBtwSpawn <= 0) {
            Instantiate(Obstacle, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
