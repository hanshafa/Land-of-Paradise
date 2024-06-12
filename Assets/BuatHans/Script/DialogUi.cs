using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class DialogUi : MonoBehaviour
{
    public GameObject[] optionButton;
    public TMP_Text[] optionButtonText;
    public GameObject optionsPanel;

    public GameObject dialogCanvas;
    public TMP_Text actor;
    public Image portrait;
    public TMP_Text dialogText;

    private void OnEnable()
    {
        gameManager.instance.movement.canMove = false;
    }
    private void OnDisable()
    {
        gameManager.instance.movement.canMove = true;

    }

}
