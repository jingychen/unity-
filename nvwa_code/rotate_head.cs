using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class rotate_head : MonoBehaviour
{
    public GameObject targetGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void turn_head()
    {
        targetGameObject.transform.DORotate(new Vector3(0, 180, 0), 3f);
    }
}
