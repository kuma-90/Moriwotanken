using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BearGameModel : MonoBehaviour
{

    float currentSpeed = 5;


    Animator animator;



    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Base", true);



        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.anyKey)
        {
            animator.SetBool("Base", true);
            animator.SetBool("Walk", false);
        }


    }



    public void MaeStraight()
    {

        rb.velocity = new Vector3(0, 0, currentSpeed);

        animator.SetBool("Walk", true);
        animator.SetBool("Base", false);

    }

    public void UshiroStraight()
    {
        rb.velocity = new Vector3(0, 0, -currentSpeed);

        animator.SetBool("Walk", true);
        animator.SetBool("Base", false);
    }

    public void HidariStraight()
    {

        rb.velocity = new Vector3(-currentSpeed, 0, 0);

        animator.SetBool("Walk", true);
        animator.SetBool("Base", false);
    }

    public void MigiStraight()
    {

        rb.velocity = new Vector3(currentSpeed, 0, 0);

        animator.SetBool("Walk", true);
        animator.SetBool("Base", false);

    }

}
