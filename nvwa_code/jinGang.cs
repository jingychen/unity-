using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jinGang : MonoBehaviour

{
    public GameObject jinGan;
    public GameObject Offsp;
    public AudioSource lights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jingang()
    {
        Invoke("Jingang2", 5f);
    }
    public void Jingang2()
    {
        jinGan.SetActive(true);
        Offsp.SetActive(true);
        lights.Play();
    }
}
