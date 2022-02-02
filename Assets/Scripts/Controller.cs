using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Animator animator; 
    public GameObject[] arow;
    private int ar = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        { animator.SetTrigger("Attack"); }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        { animator.SetTrigger("Staff"); }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        { animator.SetTrigger("Knife"); }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        { animator.SetTrigger("Light"); }

        if (Input.GetAxis("Mouse ScrollWheel") > 0 && ar == 0)
        {
            arow[ar].SetActive(!arow[ar].activeInHierarchy);
            ar = 1;
        }

        else if (Input.GetAxis("Mouse ScrollWheel") > 0 && ar == 1)
        {
            arow[0].SetActive(!arow[0].activeInHierarchy);
            arow[ar].SetActive(!arow[ar].activeInHierarchy);
            ar = 2;
        }

        else if (Input.GetAxis("Mouse ScrollWheel") > 0 && ar == 2)
        {
            arow[1].SetActive(!arow[1].activeInHierarchy);
            arow[ar].SetActive(!arow[ar].activeInHierarchy);
            ar = 3;
        }

        else if (Input.GetAxis("Mouse ScrollWheel") > 0 && ar == 3)
        {
            arow[2].SetActive(!arow[2].activeInHierarchy);
            ar = 0;
        }
    }
}
