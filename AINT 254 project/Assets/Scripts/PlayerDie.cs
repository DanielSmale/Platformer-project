﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    private void Start()
    {
    }

    void Update()
    {
        if (this.transform.position.y < -10)
        {
            FindObjectOfType<GameManager>().EndGame();
            
        }
      



    }
    

}
