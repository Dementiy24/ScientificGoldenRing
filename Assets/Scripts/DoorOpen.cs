using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] private UnityEvent placePlanet;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == this.tag)
        {
            other.GetComponent<XRGrabInteractable>().enabled = false;
            other.GetComponent<Rigidbody>().isKinematic = true;
            placePlanet.Invoke();
        }
    }
}