using System.Collections.Generic;
using UnityEngine;

public class globalStorage : MonoBehaviour
{
    public int points;
    public int difficulty; // 1: easy, 2: medium, 3: hard
    public int selectedLevel;
    public int selectedCharacter;
    public int characterSelectedToBuy;
    public bool isInterractingWithChest;
    public int timeLeft;
    public struct LevelStatus
    {
        public bool isUnlocked;
        public int numberOfStars;
    }

    // This field can be accesed through our singleton instance,
    // but it can't be set in the inspector, because we use lazy instantiation
    public List<LevelStatus> levelStatuses = new List<LevelStatus>();
    public List<int> OwnedCharacters = new List<int>();

    // Static singleton instance
    private static globalStorage instance;

    // Static singleton property
    public static globalStorage Instance
    {
        // Here we use the ?? operator, to return 'instance' if 'instance' does not equal null
        // otherwise we assign instance to a new component and return that
        get { return instance ?? (instance = new GameObject("Singleton").AddComponent<globalStorage>()); }
    }

    // Instance method, this method can be accesed through the singleton instance
    public void InitStorage()
    {
        points = 110;
        difficulty = 0;
        selectedLevel = 0;
        selectedCharacter = 0;
        characterSelectedToBuy = -1;
        isInterractingWithChest = false;
        timeLeft = 0;
        OwnedCharacters.Add(0);

        for(int i = 0; i < 4; i++)
        {
            LevelStatus level;

            level.numberOfStars = 0;

            if (i == 0)
            {
                level.isUnlocked = true;
            }
            else
            {
                level.isUnlocked = false;
            }
            levelStatuses.Add(level);
        }
    }

    public LevelStatus GetStatus(int id)
    {
        return this.levelStatuses[id];
    }

    public void SetStatus(int id, LevelStatus level)
    {
        this.levelStatuses[id] = level;
    }
}

