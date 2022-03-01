using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWithBomb : Enemy
{

    protected override void onFire()
    {
        soundFxPlayer.enemyBomb();
    }
}
