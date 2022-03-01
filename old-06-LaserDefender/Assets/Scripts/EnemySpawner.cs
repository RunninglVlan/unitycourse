using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] List<WaveConfig> waveConfigs = new List<WaveConfig>();
    [SerializeField] bool looping = false;

    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(spawnWaves());
        }
        while (looping);
    }

    private IEnumerator spawnWaves()
    {
        for (int waveIndex = 0; waveIndex < waveConfigs.Count; waveIndex++)
        {
            var wave = waveConfigs[waveIndex];
            yield return StartCoroutine(spawnEnemiesIn(wave));
        }
    }

    private IEnumerator spawnEnemiesIn(WaveConfig waveConfig)
    {
        for (int enemyCount = 0; enemyCount < waveConfig.numberOfEnemies; enemyCount++)
        {
            var enemy = Instantiate(waveConfig.enemyPrefab, waveConfig.waypoints.First().position, Quaternion.identity);
            enemy.GetComponent<EnemyPathing>().waveConfig = waveConfig;
            var randomTimeBetweenSpawns = waveConfig.timeBetweenSpawns + Random.Range(0, waveConfig.spawnRandomFactor);
            yield return new WaitForSeconds(randomTimeBetweenSpawns);
        }
    }
}
