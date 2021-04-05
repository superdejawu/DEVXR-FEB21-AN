using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{

    public GameObject shower;

    private AnimatedButton button;
    private bool follow = false;

    [Tooltip("The transform to follow for rain")]
    public Transform followTransform;

    // Start is called before the first frame update
    void Start()
    {
        button = FindObjectOfType<AnimatedButton>();
        button.OnButtonPressed += DoRain;
    }

    // Update is called once per frame
    void Update()
    {
        if(follow == true)
        {
            transform.position = followTransform.position;
        }
    }

    public void DoRain()
    {
        follow = !follow;
        shower.SetActive(follow);
    }

}
