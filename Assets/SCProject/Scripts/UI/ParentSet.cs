﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSet : MonoBehaviour {
    public GameObject ThrowParent;
    public GameObject CollisionParent;
    private bool ThrowActive;
    private bool CollisionActive;
    private List<GameObject> UIList;

    private void Awake()
    {
        ThrowActive = false;
        CollisionActive = false;
        UIList = new List<GameObject>();
    }
    public void ThrowSet()
    {
        ThrowActive = !ThrowActive;
        ThrowParent.SetActive(ThrowActive);
        ThrowDataObject.isActive = ThrowActive;

    }
    public void CollisionSet()
    {
        CollisionActive = !CollisionActive;
        CollisionParent.SetActive(CollisionActive);
        CollisonDataObject.isActive = CollisionActive;
    }

}
