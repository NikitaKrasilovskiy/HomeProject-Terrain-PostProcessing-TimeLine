using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartTimeLine : MonoBehaviour
{
    [SerializeField] private PlayableDirector timeline;
    [SerializeField] private GameObject objects;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timeline.Play();
        }
    }
    //void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        timeline.Play();
    //    }
    //}
}