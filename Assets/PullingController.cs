using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingController : MonoBehaviour
{
    public Animator animator;
    public int PullCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyPressed();
    }

    public void KeyPressed()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            PullCount = 1;
            animator.SetInteger("PullCount", PullCount);
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            PullCount = 2;
            animator.SetInteger("PullCount", PullCount);
        }
    }
}
