using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearGameModel : MonoBehaviour
{
    int speed = 3;

    Animator animator;

    public GameObject kumachan;
    // Start is called before the first frame update
    void Start()
    {
        animator = kumachan.GetComponent<Animator>();
        animator.SetBool("Base", true);
    }

    // Update is called once per frame
    void Update()
    {



    }

    public void MaeStraight()
    {
        kumachan.transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        animator.SetBool("Walk", true);
        animator.SetBool("Base", false);

    }

    public void UshiroStraight()
    {
        kumachan.transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
        animator.SetBool("Walk", true);
        animator.SetBool("Base", false);
    }

    public void HidariStraight()
    {
        kumachan.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        animator.SetBool("Walk", true);
        animator.SetBool("Base", false);
    }

    public void MigiStraight()
    {
        kumachan.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        animator.SetBool("Walk", true);
        animator.SetBool("Base", false);

    }

}
