using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

  [SerializeField]
  private GameObject dialoguePanel;
  [SerializeField]
  private Text dialogueText;

  public void DisplayDialogue(string text) {
    if (!dialoguePanel.activeSelf) dialoguePanel.SetActive(true);
    dialogueText.text = text;
  }

  public void HideDialogue() {
    dialogueText.text = "";
    dialoguePanel.SetActive(false);
  }

}
