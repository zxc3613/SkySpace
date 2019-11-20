using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Night : MonoBehaviour
{
    void Update()
    {
        float val = Mathf.PingPong(Time.time/5, 1);
        GetComponent<Renderer>().material.SetFloat("_TexValue", val);
    }
}
