using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GazClick : XRBaseInteractable //inheritance
{

    
    public float clickTime = 2;

    public float scale_offset = 0.001f;


    private float timer = 0;

    // Overrides the base XRBaseInteractable Awake
    protected override void Awake()
    {
        //we need to call the awake of the base class for things to be set up correctly
        base.Awake();

        
        onHoverEntered.AddListener(HoverEnter);
        onHoverExited.AddListener(HoverExit);
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();

        onHoverEntered.RemoveListener(HoverEnter);
        onHoverExited.RemoveListener(HoverExit);
    }

    void Update()
    {
        //isHovered is a value on XRBaseInteractable
        if (isHovered == false)
        {
            timer = 0;
            return;
        }

        //Debug.Log("Gaze: " + timer.ToString());

        if (isHovered == true)
        {
            transform.localScale = Vector3.one * (transform.localScale.x + scale_offset * Mathf.Sin(Time.time));
            transform.localScale = Vector3.one * (transform.localScale.y + scale_offset * Mathf.Sin(Time.time));
            transform.localScale = Vector3.one * (transform.localScale.z + scale_offset * Mathf.Sin(Time.time));
        }
  
    }

    void DoSomething()
    {
        
        Debug.Log("Gaze: Click");
    }

    private void HoverEnter(XRBaseInteractor interactor)
    {

        
        Debug.Log("Gaze: Hover Entered");
    }

    private void HoverExit(XRBaseInteractor interactor)
    {
       
        Debug.Log("Gaze: Hover Exited");
    }

}
