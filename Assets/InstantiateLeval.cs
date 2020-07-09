using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLeval : MonoBehaviour
{
    public GameObject[] leval;
   public int i;
    public static InstantiateLeval instance;
    private CameraFollowScript f1;
    public Camera Cm;
    // Start is called before the first frame update
    void Start()
    {
        // Leval1();
        instance = this;
        f1 = CameraFollowScript.instense;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Leval1()
    {

        Instantiate(leval[0],transform);
        // CameraFollowScript.instense.offsetPosition = new Vector3(-1.47f, 0.75f, -20);
        Cm.transform.position = new Vector3(0,-1.8f,-10f);
        i = 1;
    }
    public void Leval2()
    {

        Instantiate(leval[1], transform);
        Cm.transform.position = new Vector3(0, -1.8f, -10f);
        i = 2;
    }
    public void Leval3()
    {
        Instantiate(leval[2], transform);
        Cm.transform.position = new Vector3(0, -1.8f, -10f);
        i = 3;
    }
    public void Leval4()
    {
        Instantiate(leval[3], transform);
        Cm.transform.position = new Vector3(0, -1.8f, -10f);
        i = 4;
    }
    public void Leval5()
    {
        Instantiate(leval[4], transform);
        Cm.transform.position = new Vector3(0, -1.8f, -10f);
        i = 5;
    }
    public void Leval6()
    {
        Instantiate(leval[5], transform);
        Cm.transform.position = new Vector3(0, -1.8f, -10f);
        i = 6;
    }
    public void Leval7()
    {
        Instantiate(leval[6], transform);
        Cm.transform.position = new Vector3(0, -1.8f, -10f);
        i = 7;
    }
    public void Leval8()
    {
        Instantiate(leval[7], transform);
        Cm.transform.position = new Vector3(0, -1.8f, -10f);
        i = 8;
    }
    public void Leval9()
    {
        Instantiate(leval[8], transform);
        Cm.transform.position = new Vector3(0, -1.8f, -10f);
        i = 9;
    }
    public void Leval10()
    {
        Instantiate(leval[9], transform);
        CameraFollowScript.instense.offsetPosition = new Vector3(-0.47f, -0.67f, -20);
        i = 10;
    }
    public void Leval11()
    {
        Instantiate(leval[10], transform);
       
        i = 12;
        i = 11;
    }
    public void Leval12()
    {
        Instantiate(leval[11], transform);
        CameraFollowScript.instense.offsetPosition = new Vector3(-1.47f, 0.75f, -20);
        CameraFollowScript.instense.offsetPosition = new Vector3(-0.67f, -0.40f, -20);
        i = 12;
    }
    public void Leval13()
    {
        Instantiate(leval[12], transform);
        CameraFollowScript.instense.offsetPosition =new Vector3(0.36f,-0.52f,-20);
        i = 13;
    }
    public void Leval14()
    {
        Instantiate(leval[13], transform);
        CameraFollowScript.instense.offsetPosition = new Vector3(2.06f, -2.16f, -20);
        i = 14;
    }
    public void Leval15()
    {
        Instantiate(leval[14], transform);
        CameraFollowScript.instense.offsetPosition = new Vector3(2f, -0.34f, -20);
        i = 15;
    }
    public void resetLeval()
    {
        if(i==1)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[0], transform);
        }
        if (i == 2)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[1], transform);
        }
        if (i == 3)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[2], transform);
        }
        if (i == 4)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[3], transform);
        }
        if (i == 5)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[4], transform);
        }
        if (i == 6)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[5], transform);
        }
        if (i == 7)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[6], transform);
        }
        if (i == 8)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[7], transform);
        }
        if (i == 9)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[8], transform);
        }
        if (i == 10)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[9], transform);
        }
        if (i == 11)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[10], transform);
        }
        if (i == 12)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[11], transform);
        }
        if (i == 13)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[12], transform);
        }
        if (i == 14)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[13], transform);
        }
        if (i == 15)
        {
            GameObject shape0 = transform.GetChild(0).gameObject;
            Destroy(shape0);
            Instantiate(leval[14], transform);
        }
    }

}
