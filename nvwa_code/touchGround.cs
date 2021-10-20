using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
//using UnityEngine.Experimental.VFX;

public class touchGround : MonoBehaviour
{
    
    public GameObject[] ghosts;
    public GameObject atmosphere;
    public GameObject humans;
    private InputDevice targetDevice1; //right controller
    private InputDevice targetDevice2; //left controller
    public AudioSource growSound;
    public GameObject UI;
    // public VisualEffect myEffect;




    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices1 = new List<InputDevice>();//right controller
        List<InputDevice> devices2 = new List<InputDevice>();//left controller
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDeviceCharacteristics leftControllerCharacteristics = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices1);
        InputDevices.GetDevicesWithCharacteristics(leftControllerCharacteristics, devices2);


        foreach (var item in devices1)
        {
            Debug.Log(item.name + item.characteristics);

        }

        foreach (var item in devices2)
        {
            Debug.Log(item.name + item.characteristics);

        }
        if (devices1.Count > 0)
        {
            targetDevice1 = devices1[0];
        }
        if (devices2.Count > 0)
        {
            targetDevice2 = devices2[0];
        }

        growSound.Stop();
        growSound.loop = true;

        foreach (var ghost in ghosts)
        {
            ghost.transform.localScale = Vector3.zero;

        }

        atmosphere.transform.localScale = Vector3.zero;

        

    }

    // Update is called once per frame
    void Update()
    {
        //right controller
        targetDevice1.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 position);
        if (position.y > -0.8f)
            Debug.Log(" Right Height found" + position.y);
        if (position.y < - 1.0f)
        {
            foreach (var ghost in ghosts)
            {
                ghost.transform.localScale = Vector3.one;

            }

            atmosphere.transform.localScale = Vector3.one*50;
            UI.SetActive(false);

            if (!growSound.isPlaying)
            {
                growSound.Play();
            }


            humans.SetActive(true);

        }



        //left controller
        targetDevice2.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 position2);
        if (position2.y > -0.8f)
            Debug.Log("Left Height found" + position.y);
        if (position2.y < -1.0f)
        
        {
            foreach (var ghost in ghosts)
            {
                ghost.transform.localScale = Vector3.one;
            }

            atmosphere.transform.localScale = Vector3.one*50;
            UI.SetActive(false);

            if (!growSound.isPlaying)
            {
                growSound.Play();
            }

            humans.SetActive(true);


        }
    }
}