using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform target;

 

    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
