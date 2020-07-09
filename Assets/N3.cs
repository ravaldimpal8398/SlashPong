using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N3 : MonoBehaviour
{
    public GameObject gamemanagar;
    //public GameObject[] slis;
    //public Rigidbody2D p1;


    private HingeJoint2D hj;
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


        GameObject shape0 = transform.GetChild(0).gameObject;
        Rigidbody2D r1 = shape0.GetComponent<Rigidbody2D>();
        r1.bodyType = RigidbodyType2D.Dynamic;



    }
}
