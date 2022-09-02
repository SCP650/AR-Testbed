using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ToDoBrokenPartSpeed : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,0.6f);
    }
}
