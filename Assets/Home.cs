using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    public Canvas paly;
    public Canvas hook;
    public GameObject levaldestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void getalldata()
    {
        GameObject shape0 = transform.GetChild(0).gameObject;
        Destroy(shape0);
        paly.enabled = true;
        hook.enabled = false;

    }


}
