using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControlTrigger : MonoBehaviour
{
    //public GameObject avatar;
    public GameObject[] plants;
    private InputDevice targetDevice1; //right controller
    private InputDevice targetDevice2; //left controller
    public AudioSource growSound;
    public AudioSource growSound2;



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

        }

    // Update is called once per frame
    void Update()
    {
        //right controller
        targetDevice1.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue1);
        if (triggerValue1 > 0.1f)
            Debug.Log("Trigger pressed" + triggerValue1);
        if (triggerValue1 > 0.3f)
        //avatar.transform.localScale += new Vector3(triggerValue1*0.01f, triggerValue1 * 0.01f, triggerValue1 * 0.01f);
        {
            foreach(var plant in plants)
            {
                plant.transform.localScale += new Vector3(triggerValue1 * 0.07f, triggerValue1 * 0.07f, triggerValue1 * 0.07f);
            }
            if (!growSound.isPlaying)
            {
                growSound.Play();
            }
            if (!growSound2.isPlaying)
            {
                growSound2.Play();
            }

        }
        


        //left controller
        targetDevice2.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue2);
        if (triggerValue2 > 0.1f)
            Debug.Log("Trigger pressed" + triggerValue2);
        if (triggerValue2 > 0.3f)
        //avatar.transform.localScale -= new Vector3(triggerValue2 * 0.01f, triggerValue2 * 0.01f, triggerValue2 * 0.01f);
        {
            foreach (var plant in plants)
            {
                plant.transform.localScale -= new Vector3(triggerValue2 * 0.07f, triggerValue2 * 0.07f, triggerValue2 * 0.07f);
            }
            growSound.Stop();
            growSound2.Stop();
        }
    }
}
