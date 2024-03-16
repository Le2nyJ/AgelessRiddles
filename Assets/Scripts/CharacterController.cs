using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float Speed = 1.0f;
    [SerializeField] float rotationSpeed = 1.0f;
    [SerializeField] private CameraSwitch camSwitchScript;
    [SerializeField] GameObject[] chocolateBars;

    private float maxSpeed;
    private Animator[] animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        maxSpeed = Speed;
        rb = gameObject.GetComponent<Rigidbody>();
        animator = GetComponentsInChildren<Animator>();
        
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 Direction = new Vector3(horizontalInput, 0f, verticalInput);
        Direction.Normalize();

        Vector3 mouvement = Direction * Speed;

        if(mouvement != Vector3.zero )
        {
            Quaternion rotate = Quaternion.LookRotation(Direction, Vector3.up);

            transform.rotation = Quaternion.Slerp(transform.rotation, rotate, rotationSpeed * Time.deltaTime);
            rb.velocity = mouvement;

        }
        else
        {
            rb.velocity = Vector3.zero;
        }

        animator[0].SetBool("IsRunning", mouvement.magnitude > 0);
        animator[1].SetBool("IsRunning", mouvement.magnitude > 0);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("callSwitchUI");
            
            animator[0].Play("Eat");
            animator[1].Play("Eat");
            chocolateBars[0].SetActive(true);
            chocolateBars[1].SetActive(true);

        }
       
    }
    private IEnumerator callSwitchUI()
    {
       
        StartCoroutine("StopMouvement", 3f);
        yield return new WaitForSeconds(3f);
        chocolateBars[0].SetActive(false);
        chocolateBars[1].SetActive(false);
        camSwitchScript.triggerAnim();
    }
    private IEnumerator resetSpeed(float time)
    {
        yield return new WaitForSeconds(time);
        Speed = maxSpeed;
    }

    private IEnumerator StopMouvement(float time)
    {
        Speed = 0;
        yield return new WaitForSeconds(time);
        StartCoroutine("resetSpeed", time);
    }

    private void LaunchScaredAnim()
    {
        StartCoroutine("StopMouvement", 2.5f);
        animator[0].Play("Scared");
        animator[1].Play("Scared");
    }

    private void LaunchCrounchAnim()
    {
        animator[0].Play("Crounch");
        animator[1].Play("Crounch");
        StartCoroutine("StopMouvement", 2f);
    }

    private void LaunchCookingAnim()
    {
        animator[0].Play("Cooking");
        animator[1].Play("Cooking");
        StartCoroutine("StopMouvement", 3f);
    }
   
    public void StopMouvInteract()
    {
        Speed = 0;
    }

    public void StartMouvInteract()
    {
        Speed = maxSpeed;
    }
}
