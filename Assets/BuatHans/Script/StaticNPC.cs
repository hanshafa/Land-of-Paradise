using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticNPC : MonoBehaviour
{
    public Animator animator;
    public float flipInterval = 2f; // Interval waktu untuk flip, dapat disesuaikan di editor Unity
    private bool isFacingRight = true;

    void Start()
    {
        // Mulai coroutine untuk membalik arah NPC secara periodik
        StartCoroutine(FlipPeriodically());
    }

    IEnumerator FlipPeriodically()
    {
        while (true)
        {
            yield return new WaitForSeconds(flipInterval); // Jeda sesuai dengan interval waktu yang diset

            // Balik arah NPC
            FlipDirection();
        }
    }

    void FlipDirection()
    {
        isFacingRight = !isFacingRight;

        // Ubah arah NPC dengan membalikkan skala pada sumbu X
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
