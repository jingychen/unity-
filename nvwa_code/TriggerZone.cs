using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{

    public UnityEvent OnTriggerZoneEntered = new UnityEvent();
    public UnityEvent OnTriggerZoneExited = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (OnTriggerZoneEntered != null)
        {
            OnTriggerZoneEntered.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other);
        if (OnTriggerZoneExited != null)
        {
            OnTriggerZoneExited.Invoke();
        }
    }
}
