using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class speeeech : MonoBehaviour
{
   [SerializeField] AudioSource speech; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal"))
        {
            speech.Play();

        }
    }
}
