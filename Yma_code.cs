using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Yma_code : MonoBehaviour
{
    private Animation anim;
    //private Animator robot11, robot12;
    public Text label;
    //public GameObject robot1,robot2;
    // Use this for initialization
    void Start()
    {
        label.gameObject.SetActive(false);
        anim = this.GetComponent<Animation>();
        //robot11 = robot1.GetComponent<Animator>();
        //robot12 = robot2.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider col)
    {
        label.gameObject.SetActive(true);
        //label.PlayForward();
        anim.Play("WalkBack_Shoot");
        col.gameObject.GetComponent<Animation>().Play("Die");
        //robot11.Play("yma_robot1");
        //robot12.Play("yma_robot2");
    }
}
