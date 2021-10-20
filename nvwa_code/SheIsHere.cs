using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SheIsHere : MonoBehaviour
{
    public AudioSource Sheis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Startt()
    {
        Invoke("SheHere", 15f);

    }
    public void SheHere()
    {
        Sheis.Play();
        Invoke("LoadCity", 10f);

    }
    public void LoadCity()
    {
        SceneManager.LoadScene("city_cyborg");
    }
}
