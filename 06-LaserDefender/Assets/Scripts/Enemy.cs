using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] int laserSpeed = 10;
    [SerializeField] float firingMinInterval = .5f;
    [SerializeField] float firingMaxInterval = 1f;

    private SoundFxPlayer soundFxPlayer;

    void Start()
    {
        soundFxPlayer = FindObjectOfType<SoundFxPlayer>();
        StartCoroutine(fire());
    }

    private IEnumerator fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(firingMinInterval, firingMaxInterval));
            var laser = Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -laserSpeed);
            soundFxPlayer.enemyLaser();
        }
    }
}
