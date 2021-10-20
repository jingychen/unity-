using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audio_timelne : MonoBehaviour
   
{
    public AudioSource tellme2;
    public AudioSource nvwais2;
    public AudioSource createhuman2;
    public AudioSource disaster2;
    public AudioSource offspring2;
    public AudioSource wheresheis2;
    public AudioSource sheishere2;
    // Start is called before the first frame update
    void Start()
    {
        tellme2.Play();
        Invoke("Nvwais", 7f);
}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Nvwais()
    {
        nvwais2.Play();
        //presstriggerUI.SetActive(true);
        Invoke("ffcreatehuman",18f);


    }


    public void ffcreatehuman()
    {
        createhuman2.Play();
       //presstriggerUI.SetActive(false);
       //touchGroundUI.SetActive(true);
       //Invoke("MoveCamera", 21f);
       Invoke("fdisaster", 23f);

    }
    public void MoveCamera()
    {
        //GameObject.Find("CameraDirector").GetComponent<TimelineController>().StartTimeline();
       
        
    }

    public void fdisaster()
    {
        disaster2.Play();
        Invoke("foffspring", 54f);

    }
    public void foffspring()
    {
        offspring2.Play();
        Invoke("fwheresheis", 15f);
    }
    public void fwheresheis()

    {
        wheresheis2.Play();
        Invoke("shehere", 8);
    }
    public void shehere()

    {
        sheishere2.Play();
        
       // SceneManager.LoadScene("city_cyborg");
}
}
