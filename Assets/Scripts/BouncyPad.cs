using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyPad : MonoBehaviour
{
    [Tooltip("bounce factor to decide how much force generated through bouncy pad")]
    [SerializeField]
    private float bounceIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            other.gameObject.GetComponent<ThirdPersonMovement>().jumpHeight = bounceIndex;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            other.gameObject.GetComponent<ThirdPersonMovement>().jumpHeight = 1.5f;
    }
}
