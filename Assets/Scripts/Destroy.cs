using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void WantToDestroy()
    {
        Destroy(this.gameObject);
    }
}
