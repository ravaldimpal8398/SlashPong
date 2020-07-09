using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigJoin : MonoBehaviour
{
    public CircleCollider2D s1;
    private InstantiateLeval leval;
    public GameObject partical;

    // Start is called before the first frame update
    void Start()
    {
        leval = InstantiateLeval.instance;
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "red")
        {

            leval.i = leval.i + 1;
            Instantiate(partical, transform.position, Quaternion.identity , transform);
            Utilities.WaitAsync(1000, () => { leval.resetLeval(); });
            
            Debug.Log(" game over");
            s1.isTrigger = false;
            

        }
        else
        {

        }
    }
}
