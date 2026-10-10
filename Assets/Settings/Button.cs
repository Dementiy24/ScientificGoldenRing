using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

using UnityEngine.UI;



    public class Button: MonoBehaviour
    {
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Portal"))
            {
                Debug.Log("aaaaa");
                SceneManager.LoadScene("Level1");
            }
        }
    }

