﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralCube : MonoBehaviour
{
    private float xSize;
    private float ySize;
    private float zSize;
    [SerializeField] float sizeMin = .1f;
    [SerializeField] float sizeMax = 5f;
    public Color32[] colorPalette;
    private Color32 selectedColor;

    public void Reset()
    {
        xSize = Random.Range(sizeMin, sizeMax);
        ySize = Random.Range(sizeMin, sizeMax);
        zSize = Random.Range(sizeMin, sizeMax);
        selectedColor = colorPalette[Random.Range(0, colorPalette.Length)];
        Material cubeRenderer = GetComponent<Renderer>().material;
        cubeRenderer.color = selectedColor;
        transform.localScale = new Vector3(xSize, ySize, zSize);
    }
}