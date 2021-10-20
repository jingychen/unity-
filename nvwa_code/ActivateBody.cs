using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ActivateBody : MonoBehaviour
{
    public bool on = false;
    public GameObject targetGameObject; //body
    public GameObject targetGameObject2; //scene
    public GameObject vanishGameObject;  //ship 
    public AudioSource Sound1; //ship 
    public AudioSource Sound2; //scene
    public AudioSource Sound3; //body
    public GameObject UIEND;

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
        //targetGameObject.transform.Rotate(new Vector3(0, 1, 0), 0.5f);
        //vanishGameObject.SetActive(false);
        //targetGameObject.SetActive(true);
        //targetGameObject2.SetActive(true);

    }
    private void eliShip()
    {
        vanishGameObject.SetActive(false);
        Invoke("actScene", 3f);
    }
    private void actScene()
    {
        targetGameObject2.SetActive(true);
        Sound2.Play();
        targetGameObject2.transform.localScale = new Vector3(1.2f, 0.0f, 1.2f);
        targetGameObject2.transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 2f);

        Invoke("actBody", 3f);
    }
    private void actBody()
    {
        targetGameObject.SetActive(true);
        Sound3.Play();
        targetGameObject.transform.localScale = new Vector3(120, 0, 120);
        targetGameObject.transform.DOScale(new Vector3(120, 120, 120), 3f);

        Invoke("ui", 28f);
        Invoke("Back", 30f);
    }


    public void Switch()
    {
        if (on == false)
        {
            on = true;
            vanishGameObject.transform.DOScale(new Vector3(0, 0, 0), 2);
            Sound1.Play();
            Invoke("eliShip", 2f);
        }
        else
        {
            //on = false;
        }
    }
    public void Back()
    {
        SceneManager.LoadScene("entry");
    }
    public void ui()
    {
        UIEND.SetActive(true);
    }
}

