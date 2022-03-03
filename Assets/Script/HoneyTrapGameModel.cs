using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HoneyTrapGameModel : MonoBehaviour
{

    public UnityEvent HoneyTrapTouch = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HoneyTrapTouch.Invoke();

        }
    }
}

