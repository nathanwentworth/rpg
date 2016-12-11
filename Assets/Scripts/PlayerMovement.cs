using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using InControl;

public class PlayerMovement : MonoBehaviour {

  private Transform playerTransform;
  private bool allowPlayerMovement;
  private PlayerActions actions;
  private Vector2 dir;
  private float spellTimer;

  private List<GameObject> spellObjs;

  [SerializeField]
  private float moveSpeed;
  [SerializeField]
  private GameObject fireBall;

  private void OnEnable() {
    actions = PlayerActions.DefaultBindings();
  }

  private void Awake() {
    playerTransform = GetComponent<Transform>();
    allowPlayerMovement = true;
  }

  private void Start() {
    ObjectPooling(10, fireBall);
    DataManager.ActiveSpell = 0;
  }

  private void FixedUpdate() {
    dir = actions.Move;
    Movement(dir.normalized);

    if (actions.Fire.IsPressed) {
      int spell = DataManager.ActiveSpell;
      if (spellTimer <= 0f) {
        for (int i = 0; i < spellObjs.Count; i++) {
          if (!spellObjs[i].activeSelf) {
            spellObjs[i].transform.position = transform.position;
            spellObjs[i].SetActive(true);
            spellObjs[i].GetComponent<Rigidbody2D>().AddForce(dir.normalized * 500);
            break;
          }
        }
        spellTimer = 0.5f;
      } else {
        spellTimer -= Time.deltaTime;
      }
    } else {
      spellTimer -= Time.deltaTime;
    }
  }

  private void Movement(Vector2 dir) {
    if (allowPlayerMovement) {
      dir = dir * moveSpeed * Time.deltaTime;
      playerTransform.Translate(dir);
    }
  }

  private void ObjectPooling(int count, GameObject obj) {
    spellObjs = new List<GameObject>();
    for (int i = 0; i < count; i++) {
      GameObject inst = Instantiate(obj);
      inst.SetActive(false);
      spellObjs.Add(inst);
    }
  }





  #if UNITY_STANDALONE || UNITY_EDITOR


  

  #endif

  #if UNITY_IOS || UNITY_ANDROID




  #endif
}