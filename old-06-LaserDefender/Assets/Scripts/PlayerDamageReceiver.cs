using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{

    private HealthDisplay healthDisplay;

    protected override void Start()
    {
        base.Start();
        healthDisplay = FindObjectOfType<HealthDisplay>();
        showHealth();
    }

    protected override void onHit()
    {
        showHealth();
    }

    private void showHealth()
    {
        healthDisplay.show(health);
    }
}
