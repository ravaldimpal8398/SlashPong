using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddJoin : MonoBehaviour
{
    public GameObject gamemanagar;
    public GameObject[] slis;
    public Rigidbody2D p1;
    public Rigidbody2D p2;
    public static AddJoin Instance;
    

    private HingeJoint2D hj;
    int count = 2;
    // Start is called before the first frame update
    void Start()
    {

        Instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        // Child();
        getallprefeb();
       
        if (Input.GetButtonUp("Jump"))
        {
             Child();

        }



    }
    public void getallprefeb()
    {
       
        foreach (Transform child in transform)
            print("Foreach loop: " + child);
        if (transform.childCount==count)
        {
            Child();
            count = count + 1;

        }
    }
    public void Child()
    {


       
        GameObject shape0 = transform.GetChild(0).gameObject;
        shape0.AddComponent<HingeJoint2D>();
        GameObject shape00 = transform.GetChild(1).gameObject;
        shape00.AddComponent<HingeJoint2D>();

        Rigidbody2D previousRB = p2;
        GameObject shape = transform.GetChild(0).gameObject;
        HingeJoint2D joint = shape.GetComponent<HingeJoint2D>();
        joint.connectedBody = previousRB;
        joint.autoConfigureConnectedAnchor = false;
        joint.anchor = new Vector2(0.51f, 0f);
        joint.connectedAnchor = new Vector3(0f, 0, 0);

        Rigidbody2D previousRB2 = p1;
        Debug.Log("child");
        GameObject shape1 = transform.GetChild(1).gameObject;
        HingeJoint2D joint1 = shape1.GetComponent<HingeJoint2D>();
        joint1.connectedBody = previousRB2;
        joint1.autoConfigureConnectedAnchor = false;
        joint1.anchor = new Vector2(-0.49f, -0.03f);
        joint1.connectedAnchor = new Vector2(0f, 0f);

    }

    /*public void config()
     {

         GameObject hingeObject;
         GameObject ballObject;

         // Then:
         var joint = hingeObject.AddComponent<ConfigurableJoint>();
         joint.autoConfigureConnectedAnchor = false;
         //ballObject.transform.LookAt(hingeObject.transform);  // Optional.
         joint.connectedBody = ballObject.GetComponent<Rigidbody>();
         joint.anchor = Vector3.zero;
         var initDistance = Vector3.Distance(hindgeObject.transform.position, ballObject.transform.position);
         // ATTENTION! It's important to know what axis your joint uses!
         // If doesn't work, try to move initDistance to X or Y.
         joint.connectedAnchor = new Vector3(0, 0, initDistance);
     }*/



}
