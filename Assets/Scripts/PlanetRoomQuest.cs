using System.Collections.Generic;
using UnityEngine;

public class PlanetRoomQuest : MonoBehaviour
{
    [SerializeField] List<PlanetCounter> quests;

    [SerializeField] GameObject door;

    private void CheckQuestEnd()
    {
        int currentPlaced = 0;

        foreach (PlanetCounter quest in quests)
        { 
            if(quest.IsComplete())
            {
                currentPlaced++;
                Debug.Log(currentPlaced);
            }
        }

        if(currentPlaced == quests.Count)
        {
            Debug.Log("works");
            door.SetActive(false);
        }
    }
}
