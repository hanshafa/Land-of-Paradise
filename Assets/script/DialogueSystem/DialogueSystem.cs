using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueSystem : MonoBehaviour
    {
        public bool finished {  get; private set; }
        protected IEnumerator writeText(string input, Text textHolder, Color textColor, Font textFont, float delay, AudioClip sound, float delayBetweenLines )
        {
            textHolder.color = textColor;
            textHolder.font = textFont;
            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                SoundManager.instance.PlayeSound(sound);
                yield return new WaitForSeconds(delay);
            }
            yield return new WaitForSeconds(delayBetweenLines);

            finished = true;
        }
    }
}