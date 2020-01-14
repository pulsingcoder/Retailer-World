using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    GameObject source;
    Rigidbody rb;
    public float walkSpeed;
    Quaternion myScale;
    float scaleParam = 90;
    Animation myAnim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myScale = gameObject.transform.localRotation;
        myAnim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = gameObject.transform.position;
        // 

        if (pos.x < source.transform.position.x)
        {
            print(source.transform.position.x + " " + gameObject.transform.position.x);
            print(true);
            rb.velocity = new Vector3(walkSpeed, rb.velocity.y, rb.velocity.z);

        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
            myScale.y += scaleParam;
            scaleParam = 0;
            gameObject.transform.localRotation = myScale;
            myAnim.Stop();
        }
            
        
    }
}
