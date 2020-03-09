using UnityEngine;
using System.Collections;

public class worldTrigger : MonoBehaviour
{

    private GameObject portal;
    void Start()
    {
        portal = GameObject.Find("portal");
        portal.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            portal.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            portal.gameObject.SetActive(false);
        }
    }
}