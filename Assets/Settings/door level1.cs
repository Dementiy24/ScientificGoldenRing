using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

using UnityEngine.UI;



public class door : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal"))
        {
            Debug.Log("aaaaa");
            SceneManager.LoadScene("level2");
        }
    }
}


