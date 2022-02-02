using UnityEngine;

[RequireComponent(typeof(CharacterController2D))]
public class PlayerInput : MonoBehaviour {
    [SerializeField] private float runSpeed = 40f;

    private CharacterController2D controller;
    private Animator animator;

    private float horizontalMove = 0f;
    private bool isJumping = false;

    private void Awake() {
        controller = GetComponent<CharacterController2D>();
        animator = GetComponent<Animator>();
    }

    private void Update() {
        // determine movement
        horizontalMove = Input.GetAxisRaw("Horizontal") * -runSpeed;
        Debug.Log("Horizontal move: " + horizontalMove);

        // determine jumping
        if (Input.GetButtonDown("Jump")) {
            isJumping = true;
            animator.SetTrigger("Jump");
        }

        // show the correct animation
        animator.SetFloat("Speed", Mathf.Abs(controller.speed));
    }

    private void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, isJumping);
        isJumping = false;
    }
}
