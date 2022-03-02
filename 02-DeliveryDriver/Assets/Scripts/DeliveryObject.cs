using System;
using UnityEngine;

public class DeliveryObject : MonoBehaviour {
    [SerializeField] SpriteRenderer spriteRenderer = null!;

    public DeliveryObject Customer { get; set; }

    public Color Color {
        set => spriteRenderer.color = value;
    }

    public int SortingOrder {
        set => spriteRenderer.sortingOrder = value;
    }
}
