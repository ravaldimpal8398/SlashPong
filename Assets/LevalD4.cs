using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevalD4 : MonoBehaviour
{

    public GameObject gamemanagar;
    public GameObject[] slis;
    public Rigidbody2D p1;
    public Rigidbody2D p2;
    private Rigidbody2D un1;


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




       
       /* GameObject shape = transform.GetChild(0).gameObject;
     
        un1 = shape.GetComponent<Rigidbody2D>();
        un1.gravityScale = -3;*/



       

        Debug.Log("child");
        GameObject shape1 = transform.GetChild(1).gameObject;
        shape1.GetComponent<Rigidbody2D>().gravityScale = -1;
        shape1.GetComponent<Rigidbody2D>().drag = 10;
        shape1.GetComponent<Rigidbody2D>().mass = 100;





    }
}
