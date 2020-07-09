using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leval3Join : MonoBehaviour
{
    public GameObject gamemanagar;
    public GameObject[] slis;
    public Rigidbody2D p1;


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



       
               

        Rigidbody2D previousRB2 = p1;
        Debug.Log("child");
        GameObject shape1 = transform.GetChild(1).gameObject;
        HingeJoint2D joint1 = shape1.GetComponent<HingeJoint2D>();
        joint1.connectedBody = previousRB2;
        joint1.autoConfigureConnectedAnchor = false;
        joint1.anchor = new Vector2(-0.48f, -0.01f);
        joint1.connectedAnchor = new Vector2(-0.01f, 3.38f);

        GameObject shape0 = transform.GetChild(0).gameObject;
        HingeJoint2D joint0 = shape0.GetComponent<HingeJoint2D>();
        joint0.breakForce = 1;
       


    }
}
