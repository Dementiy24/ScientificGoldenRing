using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] GameObject axePrefab;

    void Update()
    {
        if (axePrefab.GetComponent<XRGrabInteractable>().enabled == false)
        {
            Debug.Log("works");
            Instantiate(axePrefab, transform);
        }
    }
}
