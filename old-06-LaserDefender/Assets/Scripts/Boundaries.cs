﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{

    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
