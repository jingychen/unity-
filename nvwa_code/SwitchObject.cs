using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    public bool on = false;
    public GameObject targetGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (on == false)
        {
            return;
        }
        targetGameObject.transform.Rotate(new Vector3(0, 1, 0), 0.5f);

    }

    public void Switch()
    {
        if(on == false)
        {
            on = true;
        }
        else
        {
            on = false;
        }
    }
}
