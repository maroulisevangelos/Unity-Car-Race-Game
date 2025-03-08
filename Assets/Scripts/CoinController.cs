using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Renderer coinRenderer;
    private Collider coinCollider;

    // Start is called before the first frame update
    void Start()
    {
        coinRenderer = GetComponent<Renderer>();
        coinCollider = GetComponent<Collider>();
        SetRandomVisibility();
    }

    void SetRandomVisibility()
    {
        bool isVisible = Random.Range(0, 2) == 0; // 50% chance of being visible
        coinCollider.enabled = isVisible;
        coinRenderer.enabled = isVisible;
    }
}
