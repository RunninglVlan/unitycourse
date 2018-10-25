using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFxPlayer : MonoBehaviour
{

    [SerializeField] AudioClip playerLaserSound;
    [Range(0, 1)]
    [SerializeField] float playerLaserVolume = .5f;
    [SerializeField] AudioClip enemyLaserSound;
    [SerializeField] AudioClip damageSound;
    [SerializeField] AudioClip explosionSound;
    [Range(0, 1)]
    [SerializeField] float explosionVolume = .5f;

    public void playerLaser()
    {
        playAtCameraPosition(playerLaserSound, playerLaserVolume);
    }

    public void enemyLaser()
    {
        playAtCameraPosition(enemyLaserSound);
    }

    public void damage()
    {
        playAtCameraPosition(damageSound);
    }

    public void explosion()
    {
        playAtCameraPosition(explosionSound, explosionVolume);
    }

    private void playAtCameraPosition(AudioClip sound)
    {
        AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
    }

    private void playAtCameraPosition(AudioClip sound, float volume)
    {
        AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position, volume);
    }
}
