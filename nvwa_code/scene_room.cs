using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;

public class scene_room : MonoBehaviour
{
    public AudioSource Sound1;
    public AudioSource Sound2;
    public AudioSource bg;
    public GameObject targetGameObject;
    private float[] samples = new float[1024];

    // Start is called before the first frame update
    void Start()
    {
        Sound1.Play();
        Sound1.loop = true;
        Sound2.Play();
        Sound2.loop = true; 

    }


    // Update is called once per frame
    void Update()
    {
       
            SpectrumTrans(Sound1);
        

        //Debug.Log(Time.deltaTime);
    }

   

    private void SpectrumTrans(AudioSource sound)
    {

        sound.GetSpectrumData(samples, 0, FFTWindow.BlackmanHarris);

        for (int i = 0; i < 1024; i++)
        {

            float s = samples[i];

            targetGameObject.transform.localPosition = new Vector3(targetGameObject.transform.localPosition.x, targetGameObject.transform.localPosition.y+s/5.0f* Random.Range(-1.0f, 1.0f), targetGameObject.transform.localPosition.z);
            //targetGameObject.transform.localPosition = new Vector3(-0.63f, -2.94f, 0.78f);
            // targetGameObject.transform.DOPunchPosition(new Vector3(0, s / 10.0f, 0), 1, 5, 0.1f);
            //targetGameObject.transform.DOShakeRotation(s);
            //targetGameObject.transform.DOShakePosition(1, 0.01f, 3, 1, true);
            //Debug.Log(s);
           
        }


    }

}
