﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrideMoveAdd : MonoBehaviour
{
    public GameObject EncounterPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPrideAttack()
    {
        EncounterPanel.GetComponent<MoveAssignment>().MoveAssigned = false;
        EncounterPanel.GetComponent<MoveAssignment>().MoveNum = 4;
        EncounterPanel.GetComponent<MoveAssignment>().AddMove();
        Debug.Log("Add Pride Move");
    }
}
