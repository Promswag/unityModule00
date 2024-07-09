using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using UnityEditor.MemoryProfiler;


// using System.Numerics;
using UnityEngine;

public class AutofitMaterial : MonoBehaviour
{
    private MeshRenderer mesh;
    void Start()
    {
        UnityEngine.Vector3 scale = gameObject.transform.localScale;
        mesh = GetComponent<MeshRenderer>();
        mesh.material.SetTextureScale("_MainTex", new Vector2(scale.x, scale.z));
    }
}
