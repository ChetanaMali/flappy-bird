using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BachgroundScroll : MonoBehaviour
{
    [SerializeField] Renderer meshrender;
    public float backGroundMoveSpeed = 0.1f;
    void Update()
    {
        meshrender.material.mainTextureOffset += new Vector2(backGroundMoveSpeed * Time.deltaTime, 0);

    }
}
