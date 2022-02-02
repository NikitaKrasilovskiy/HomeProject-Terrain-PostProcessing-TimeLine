using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform trans;
    [SerializeField] private AudioSource TeleportSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponentInParent<Rigidbody>();
            other.transform.position = trans.transform.position;
            TeleportSound.Play();
        }
    }
}