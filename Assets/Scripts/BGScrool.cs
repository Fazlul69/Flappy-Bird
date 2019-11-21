﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrool : MonoBehaviour
{

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * 0.5f;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
