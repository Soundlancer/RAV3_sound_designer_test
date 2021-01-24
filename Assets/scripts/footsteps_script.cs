using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps_script : MonoBehaviour
{
    public AK.Wwise.Event footstepsEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        { footstepsEvent.Post(gameObject); }
        if (Input.GetKeyUp(KeyCode.W))
        { footstepsEvent.Stop(gameObject); }
        if (Input.GetKeyDown(KeyCode.A))
        { footstepsEvent.Post(gameObject); }
        if (Input.GetKeyUp(KeyCode.A))
        { footstepsEvent.Stop(gameObject); }
        if (Input.GetKeyDown(KeyCode.S))
        { footstepsEvent.Post(gameObject); }
        if (Input.GetKeyUp(KeyCode.S))
        { footstepsEvent.Stop(gameObject); }
        if (Input.GetKeyDown(KeyCode.D))
        { footstepsEvent.Post(gameObject); }
        if (Input.GetKeyUp(KeyCode.D))
        { footstepsEvent.Stop(gameObject); }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { footstepsEvent.Post(gameObject); }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        { footstepsEvent.Stop(gameObject); }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        { footstepsEvent.Post(gameObject); }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        { footstepsEvent.Stop(gameObject); }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { footstepsEvent.Post(gameObject); }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        { footstepsEvent.Stop(gameObject); }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        { footstepsEvent.Post(gameObject); }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        { footstepsEvent.Stop(gameObject); }
    }
}
