using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PlaceObjectOnTouch : MonoBehaviour
{
    public GameObject objectToPlacePrefab;
    public ARRaycastManager raycastManager;

    private GameObject gb;

    // Update is called once per frame
    void Update()
    {
        //UpdateCursor();
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Debug.Log("Touch Registered !");
            //if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)) return;
            //Instantiate(objectToPlacePrefab, transform.position, transform.rotation);
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            raycastManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
            if (hits.Count > 0)
            {
                if(gb == null)
                {
                    Debug.Log("Placed TODO Object!");
                    gb = Instantiate(objectToPlacePrefab, hits[0].pose.position, Quaternion.identity);
                }
                else
                {
                    Debug.Log("Break TODO Object!");
                    gb.GetComponent<ToDoToggle>().ToDoBreakObjects();
                    gb = null;
                }
               
            }
        }
    }
}