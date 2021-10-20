using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class audios : MonoBehaviour
{
    public AudioSource tellme;
    public AudioSource nvwais;
    public AudioSource createhuman;
    public AudioSource disaster;
    public AudioSource offspring;
    public AudioSource wheresheis;
    public GameObject presstriggerUI;
    public GameObject touchGroundUI;
    public GameObject voidd;
    public GameObject terrain;
    public GameObject grows;
    //public GameObject Columns;
    //public GameObject Buryy;







    // Start is called before the first frame update
    void Start()
    {
        tellme.Play();
        Invoke("Nvwais", 6f);
        terrain.SetActive(false);
        //Columns.SetActive(false);
        grows.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Nvwais()
    {
        nvwais.Play();
        presstriggerUI.SetActive(true);
        voidd.SetActive(false);
        voidd.transform.DOScale(new Vector3(0.0f, 0.0f, 0.0f), 2f);
        Invoke("cancelVoidLight", 2f);
        terrain.SetActive(true);
        grows.SetActive(true);
        Invoke("fcreatehuman", 17f);


    }

    public void cancelVoidLight()
    {
        voidd.SetActive(false);

    }
    public void fcreatehuman()
    {
        createhuman.Play();
        presstriggerUI.SetActive(false);
        touchGroundUI.SetActive(true);
        //Columns.SetActive(true);
        Invoke("MoveCamera", 21f);

    }
    public void MoveCamera()
    {
        GameObject.Find("CameraDirector").GetComponent<TimelineController>().StartTimeline();
        Invoke("fdisaster", 5f);
        

    }

    public void fdisaster()
    {
        disaster.Play();
        //touchGroundUI.SetActive(false);

        // Invoke("fBury", 20f);

    }
    public void fBury()
    {
        //Buryy.SetActive(true);


    }
    public void foffspring()
    {
        offspring.Play();
    }
    public void fwheresheis()

    {
        wheresheis.Play();
    }

}
