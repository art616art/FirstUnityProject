using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    private int health = 100;
    private int level = 1;
    void Start()
    {
        health += level;
        print("Здоровье npc: "health);
    }

    void Update()
    {
        
    }
}
