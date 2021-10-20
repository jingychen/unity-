using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nvwaAppear : MonoBehaviour
{
    public GameObject nvwa; //body
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Startfunction()
    {
        Invoke("actNvwa", 22f);
    }
    private void actNvwa()
    {
        nvwa.SetActive(true);
   
    }
}
