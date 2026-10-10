using UnityEngine;

public class PlanetCounter : MonoBehaviour
{
    private bool isComplete = false;

    public void CompleteQuest()
    {
        isComplete = true;
    }

    public bool IsComplete()
    {
        return isComplete;
    }
}
