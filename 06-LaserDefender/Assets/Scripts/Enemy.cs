using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] int projectileSpeed = 10;
    [SerializeField] float firingMinInterval = .5f;
    [SerializeField] float firingMaxInterval = 1f;

    protected SoundFxPlayer soundFxPlayer;

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
            var projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -projectileSpeed);
            onFire();
        }
    }

    protected virtual void onFire()
    {
        soundFxPlayer.enemyLaser();
    }
}
