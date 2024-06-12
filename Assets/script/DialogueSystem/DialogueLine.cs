using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueSystem
    {
        private Text textHolder;

        [Header("Text Optons")]
        [SerializeField]private string input;
        [SerializeField] private Color textColor;
        [SerializeField] private Font textFont;

        [Header("Time Parameter")]
        [SerializeField]private float delay;
        [SerializeField]private float delayBetweenLines;

        [Header("Sound")]
        [SerializeField] private AudioClip sound;
        [Header("Character")]
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image imageHolder;

        private void Awake()
        {
            textHolder = GetComponent<Text>();

            textHolder.text = "";

            imageHolder.sprite = characterSprite;
            imageHolder.preserveAspect = true;
        }

        private void Start()
        {
            StartCoroutine(writeText(input, textHolder,textColor,textFont,delay,sound,delayBetweenLines));

        }
    }
       
}
