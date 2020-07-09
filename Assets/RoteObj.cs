using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoteObj : MonoBehaviour
{
    public float smooth = 5.0F;
    public float tiltAngle = -360.0F;
    float degrees = 360;
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;
    int count = 2;
    public GameObject mater;
    private AddJoin setCount;
    int i = 0;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    // Start is called before the first frame update
    void Start()
    {
        // Keep a note of the time the movement started.
    /*    startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        setCount = AddJoin.Instance;*/
        
    }

    // Update is called once per frame
    void Update()

    {
        if (i==1)
        {

       
        // Distance moved equals elapsed time times speed..
       float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);

        transform.Rotate(0, 0, -360);
        }
        // transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
        transform.Rotate(new Vector3(0,0,-360) * 2 * Time.deltaTime, 1);
       // transform.position = new Vector3(10,0 , 0);
       

    }
    public void getallprefeb()
    {

        if (setCount.gamemanagar.transform.childCount==count)
        {
            hit();
            count = count + 1;

        }

    }


    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Static")
        {



            Debug.Log("Rotetion Start");
            i = 1;
            startTime = Time.time;

            // Calculate the journey length.
            journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
            // Distance moved equals elapsed time times speed..
            float distCovered = (Time.time - startTime) * speed;

            // Fraction of journey completed equals current distance divided by total distance.
            float fractionOfJourney = distCovered / journeyLength;

            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);



        }
    }

        public void hit()

    {

        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);

    }
  
}
