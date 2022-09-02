using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDoToggle : MonoBehaviour
{
    public GameObject beforeBreak;
    public GameObject afterBreak;
    public AudioSource audio;

    private void Start()
    {
        afterBreak.SetActive(false);
    }

    public void ToDoBreakObjects()
    {
        audio.time = 0.2f;
        audio.Play();
        beforeBreak.SetActive(false);
        afterBreak.SetActive(true);
    }

#if UNITY_EDITOR
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 70, 50, 30), "Break"))
            ToDoBreakObjects();
    }
#endif
}
