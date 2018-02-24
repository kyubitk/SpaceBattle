using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pather1 : MonoBehaviour {

    public Transform[] iPath;
    public Transform target;
    public float speed = 5.0f;
    public int iPoint = 0;
    private int destPoint;
    public float RotationSpeed;
    private Quaternion lookRot;
    private Vector3 dir;


    // Update is called once per frame
    void Update()
    {
       
        if (transform.position != iPath[destPoint].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, iPath[destPoint].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

            transform.LookAt(pos);
            //dir = iPath[destPoint].position - transform.position;
            //lookRot = Quaternion.LookRotation(dir);
            //transform.rotation = lookRot;
        }
        else
        {
            destPoint = (destPoint + 1) % iPath.Length;
        }



    }


}
