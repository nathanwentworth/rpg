using UnityEngine;
using System.Collections;
using InControl;

public class PlayerMovement : MonoBehaviour {

  private Transform playerTransform;
  private bool allowPlayerMovement;
  private PlayerActions actions;
  private Vector2 dir;

  [SerializeField]
  private float moveSpeed;

  private void OnEnable() {
    actions = PlayerActions.DefaultBindings();
  }

  private void Awake() {
    playerTransform = GetComponent<Transform>();
    allowPlayerMovement = true;
  }

  private void FixedUpdate() {
    dir = actions.Move;
    Movement(dir);

    if (actions.Fire.IsPressed) {
      int spell = Shooting.ActiveSpell;
      Shoot(spell);
    }
  }

  private void Movement(Vector2 dir) {
    if (allowPlayerMovement) {
      dir = dir * moveSpeed * Time.deltaTime;
      // dir.X = dir.X * moveSpeed * Time.deltaTime;
      // dir.Y = dir.Y * moveSpeed * Time.deltaTime;
      // Vector2 dir = new Vector2 (x, y);
      // playerTransform.Translate(x * moveSpeed * Time.deltaTime);
      // playerTransform.Translate(y * moveSpeed * Time.deltaTime);
      playerTransform.Translate(dir);
    }
  }

  private void Shoot (int spell) {
    
  }





  #if UNITY_STANDALONE || UNITY_EDITOR


  

  #endif

  #if UNITY_IOS || UNITY_ANDROID




  #endif
}