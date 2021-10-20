using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiactive1 : MonoBehaviour
{
    public GameObject UII;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void act()
    {
        UII.SetActive(true);
    }
    public void nonact()
    {
        UII.SetActive(false);
    }
}
