using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{

    public float scale_offset;
    
    // Start is called before the first frame update
    void Start()
    {
        scale_offset = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one * (transform.localScale.x + scale_offset * Mathf.Sin(Time.time));
        transform.localScale = Vector3.one * (transform.localScale.y + scale_offset * Mathf.Sin(Time.time));
        transform.localScale = Vector3.one * (transform.localScale.z + scale_offset * Mathf.Sin(Time.time));
    }
}
