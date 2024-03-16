using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class I_Stove : Interactable_Object
{
    private InteracitveUI interactiveUI;
    private ParticleSystem smoke;
    [SerializeField] GameObject cakePrefab;
    [SerializeField] Transform cakePos;
    [SerializeField] Animator switchAnimator;
    // Start is called before the first frame update
    void Start()
    {
        startSetup();
        smoke = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        updateSetup();
    }

    protected override void Interaction()
    {
        if (!_gameManager.GetComponent<CurrentEnigme>().isInChildWorld() && _gameManager.GetComponent<CurrentEnigme>().getCurrentEnigmeID() == nbrEnigme)
        {
            smoke.Play();
            StartCoroutine("SpawnCake");
            _gameManager.GetComponent<CurrentEnigme>().addCurrentEnigme();
        }        
    }

    IEnumerator SpawnCake()
    {
        yield return new WaitForSeconds(5f);
        Instantiate(cakePrefab, cakePos);
        yield return new WaitForSeconds(3f);
        switchAnimator.SetTrigger("switchWorld");
        StartCoroutine("changeScene");
    }
    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(3);
    }
}
