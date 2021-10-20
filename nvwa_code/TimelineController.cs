using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    private PlayableDirector director;
    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
        director.played += DirectorPlayed;
        director.stopped += DirectorStopped;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void DirectorPlayed(PlayableDirector obj)
    {
        Debug.Log("Player Started");
    }
    private void DirectorStopped(PlayableDirector obj)
    {
        Debug.Log("Player Stopped");
        //You could use this to perhaps clue your user into moving to a new area
    }
    public void StartTimeline()
    {
        Debug.Log("Play");
        director.Play();
    }
}
