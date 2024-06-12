using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public Animator animator;
    public float flipInterval = 2f; // Interval waktu untuk flip, dapat disesuaikan di editor Unity
    public float moveSpeed = 2f; // Kecepatan pergerakan NPC
    public float idleDuration = 1f; // Durasi jeda idle sebelum dan setelah flip
    private bool isFacingRight = true;
    private bool isFlipping = false; // Menandakan apakah NPC sedang dalam proses flip
    private Vector3 flipDirection; // Arah flip

    void Start()
    {
        // Mulai coroutine untuk membalik arah NPC secara periodik
        StartCoroutine(FlipPeriodically());
        flipDirection = Vector3.right; // Mulai dengan bergerak ke kanan
    }

    IEnumerator FlipPeriodically()
    {
        while (true)
        {
            // Jeda sebelum flip
            yield return new WaitForSeconds(idleDuration);

            // Balik arah NPC
            if (!isFlipping)
            {
                flipDirection = isFacingRight ? Vector3.left : Vector3.right;
                StartCoroutine(Flip());
            }

            // Jeda setelah flip
            yield return new WaitForSeconds(flipInterval);
        }
    }

    IEnumerator Flip()
    {
        isFlipping = true;

        // Hentikan pergerakan NPC sementara
        float originalSpeed = moveSpeed;
        moveSpeed = 0f;

        // Set animator parameter to idle
        animator.SetBool("isWalking", false);

        // Jeda idle sebelum flip
        yield return new WaitForSeconds(idleDuration);

        // Animasi flip
        // Ubah arah NPC dengan membalikkan skala pada sumbu X
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;

        // Tunggu sebentar sebelum melanjutkan pergerakan
        yield return new WaitForSeconds(0.1f);

        // Lanjutkan pergerakan NPC
        moveSpeed = originalSpeed;
        isFacingRight = !isFacingRight;
        isFlipping = false;
    }

    void Update()
    {
        // Pergerakan NPC
        if (!isFlipping)
        {
            transform.Translate(flipDirection * moveSpeed * Time.deltaTime);
        }

        // Set animator parameter
        animator.SetBool("isWalking", !isFlipping && moveSpeed > 0);
    }
}
