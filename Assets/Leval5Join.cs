using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leval5Join : MonoBehaviour
{
    public GameObject gamemanagar;
    private Rigidbody2D r1;
    int count = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        getallprefeb();
    }
    public void getallprefeb()
    {

        foreach (Transform child in transform)
            print("Foreach loop: " + child);
        if (transform.childCount == count)
        {
            Child();
            count = count + 1;

        }

    }
    public void Child()
    {







        Debug.Log("child");
       /* GameObject shape1 = transform.GetChild(1).gameObject;
        //HingeJoint2D joint1 = shape1.GetComponent<HingeJoint2D>();
        Rigidbody2D r = shape1.GetComponent<Rigidbody2D>();
        r.bodyType = RigidbodyType2D.Dynamic;*/


        GameObject shape0 = transform.GetChild(0).gameObject;
        Rigidbody2D r1 = shape0.GetComponent<Rigidbody2D>();
        r1.bodyType = RigidbodyType2D.Dynamic;




    }
}
