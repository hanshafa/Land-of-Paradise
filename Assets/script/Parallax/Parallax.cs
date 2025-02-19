using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Material mats;
    float distance;

    [Range(0f, 0.5f)]
    public float speed=0.2f;

    // Start is called before the first frame update
    void Start()
    {
        mats = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime * speed;
        mats.SetTextureOffset("_MainTex", Vector2.right * distance);
    }
}
