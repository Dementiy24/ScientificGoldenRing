using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ThrowingSystem : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] GameObject axePrefab;
    [SerializeField] GameObject doorPrefab;


    Rigidbody physics;
    XRGrabInteractable interactable;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("axe"))
        {          
            audioSource.Play();
            physics = other.gameObject.GetComponent<Rigidbody>();
            physics.isKinematic = true;

            interactable = other.gameObject.GetComponent<XRGrabInteractable>();
            interactable.enabled = false;

            DestroyDoor();
        }
    }

    private void DestroyDoor()
    {
        doorPrefab.SetActive(false);
    }
}
