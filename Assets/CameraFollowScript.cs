using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour
{
    public static CameraFollowScript instense;
    [SerializeField]
    private Transform target;

    [SerializeField]
    public Vector3 offsetPosition;

    [SerializeField]
    public Space offsetPositionSpace = Space.Self;
    [SerializeField]
    // private bool lookAt = true;
    public TrailRenderer BlueBall;
    GameObject ball;


    void Start()
    {
        instense = this;
        //getball = Ballinstens.instansan;
        // BlueBall = gameObject.tag ;

        
        // target.transform = ball.transform;
       
    }

    private void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Blue");
        target = ball.transform;
        Refresh();
    }
    public void getPlayar(Transform ball)
    {

        target = ball.transform;
    }

    public void Refresh()
    {
        if (target == null)
        {
            //Debug.LogWarning("Missing target ref !", this);

            return;
        }

        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }

        // compute rotation
        /*if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }*/

    }
}
