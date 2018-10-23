using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] int laserSpeed = 10;
    [SerializeField] float firingMinInterval = .5f;
    [SerializeField] float firingMaxInterval = 1f;

    void Start()
    {
        StartCoroutine(fire());
    }

    private IEnumerator fire()
    {
        while (true)
        {
            var laser = Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -laserSpeed);
            yield return new WaitForSeconds(Random.Range(firingMinInterval, firingMaxInterval));
        }
    }
}
