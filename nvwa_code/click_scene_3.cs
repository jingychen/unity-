using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class click_scene_3 : MonoBehaviour
{
    private InputDevice targetDevice1; //right controller
    private InputDevice targetDevice2; //left controller

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
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Click()
    {
        //right controller
        targetDevice1.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue1);
        if (triggerValue1 >0.01)
            Debug.Log("Trigger pressed" + triggerValue1);
        if (triggerValue1 > 0.01)

        {
            SceneManager.LoadScene("final");
        }
        



        //left controller
        targetDevice2.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue2);
        if (triggerValue2 > 0.01)
            Debug.Log("Trigger pressed" + triggerValue2);
        if (triggerValue2 > 0.01)

        {
            SceneManager.LoadScene("final");
        }
    }

}
