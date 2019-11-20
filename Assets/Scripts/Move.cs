using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Transform earth;
    [SerializeField] Transform month;

    float Earth;
    float Month;

    void Update()
    {
        Earth += 0.2f;
        earth.rotation = Quaternion.Euler(0, Earth, 0);

        month.rotation = Quaternion.Euler(0, Earth, 0);
        
        Month += 1f;
        transform.rotation = Quaternion.Euler(0, Month, 0);
    }
}
