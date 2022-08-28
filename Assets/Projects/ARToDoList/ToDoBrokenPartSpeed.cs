using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ToDoBrokenPartSpeed : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(1f, 2), Random.Range(1f, 2), Random.Range(1f, 2));
    }
}
