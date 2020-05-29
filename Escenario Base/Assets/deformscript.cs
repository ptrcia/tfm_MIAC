using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deformscript : MonoBehaviour
{
    //[SerializeField] private string loadLevel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //other.CompareTag("Ground").GetComponent<TwistDeformer>().enabled = false;
        }
    }
}

