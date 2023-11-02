using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactEffect : MonoBehaviour
{
    [SerializeField] private float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }
}
