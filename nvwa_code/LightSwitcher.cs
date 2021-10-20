using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    public bool on = false;
    public List<GameObject> lights = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if(on == true)
        {
            SwitchOn();
        }
        else
        {
            SwitchOff();
        }
    }

    private void SwitchOn()
    {
        on = true;
        for(int i = 0; i < lights.Count; i++)
        {
            lights[i].SetActive(true);
        }
    }

    private void SwitchOff()
    {
        on = false;
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].SetActive(false);
        }
    }
     
    public void Switch()
    {
        if (on == false)
        {
            SwitchOn();
        }
        else
        {
            SwitchOff();
        }
    }
}
