﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour {

    public GameObject mDoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Animator>().enabled = true;

        mDoor.GetComponent<Door>().Open();
    }
}
