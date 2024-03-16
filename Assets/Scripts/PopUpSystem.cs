using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PopUpSystem : MonoBehaviour
{
    [SerializeField] RawImage m_bubbleImage;
    [SerializeField] TMP_Text m_bubbleTxt;
    [SerializeField] float m_duration;
    [SerializeField] float m_maxDuration;
    [SerializeField] CurrentEnigme m_currentEnigme;
    [SerializeField] TMP_FontAsset childFont;
    [SerializeField] TMP_FontAsset adultFont;
    public void MessageList(int idMessage)
    {
        string message = "";

        switch (idMessage)
        {
            case 0:
                message = "Je me souviens lorsque j'etais enfant... tout etait plus simple";
                break;

            case 1:
                message = "Cette graine me rapelle lorsque je jardiner avec mes parents...";
                break;

            case 2:
                message = "Il faut que j'accede a ma chambre, ou ai-je mis ma clef ?";
                break;

            case 3:
                message = "Comment ai-je-pu la laisser la ?";
                break;
            case 4:
                message = "Je n'avais jamais acces au pc quand j'etais petit...";
                break;
                
            case 5:
                message = "";
                break;
            case 6:
                message = "";
                break;
            case 7:
                message = "Oh je crois que j'ai recu un message !";
                break;
            case 8:
                message = "J'avais mon rendez-vous ! Il faut que je me prepare";
                break;
            case 9:
                message = "Pourquoi n'ai-je jamais appris a ranger quand j'etais petit...";
                break;
            case 10:
                message = "Ou est ce que maman rangais la cle, du placard a produit menage ?";
                break;
            case 11:
                //En tant qu'enfant Nettoyer la salle de bain
                message = "Comme d'habitude sous le canape comme quand j'etais petit...";
                break;
            case 12:
                message = "Je peux prendre la javel";
                break;
            case 13:
                message = "Ces toilette merite d'etre propre";
                break;
            case 14:
                //En tant qu'enfant trouver la recette
                message = "Maintenant que je suis propre, il faut que je prepare le gateau, la recette de ma mere est la meilleure de toute";
                break;
            case 15:
                message = "Plus qu'a preparer le gateau";
                break;
            case 16:
                message = "Plus qu'a preparer le gateau";
                break;
            case 17:
                message = "Vous avez fini le jeu";
                break;

            default:
                message = "";
                break;
        }
        m_bubbleTxt.text = message;
        m_bubbleImage.enabled = true;

        
    }

    void check()
    {
        if (m_currentEnigme.isInChildWorld())
        {
            m_bubbleTxt.font = childFont;
        }
        else
        {
            m_bubbleTxt.font = adultFont;
        }
    }
    void DeleteMessage()
    {
        if (m_bubbleTxt.text != "")
        {
            m_duration -= Time.deltaTime;
            if (m_duration <= 0)
            {
                m_bubbleTxt.text = "";
                m_bubbleImage.enabled = false;
                m_duration = m_maxDuration;
            }
            
        }
    }
    private void Start()
    { 
        m_duration = m_maxDuration;
        m_bubbleTxt.text = "";
        m_bubbleImage.enabled = false;
    }
    private void Update()
    {
        check();
    }

    public void ErrorMessage(int id)
    {
        string message = "";
        switch (id)
        {
            case 1:
                message = "Ce n'est pas le bon moment";
                break;
            case 2:
                message = "Rien ne se passe";
                break;
            case 3:
                message = "Je devrais aller voir ailleurs";
                break;
            case 4:
                message = "Je ne peux rien faire ici";
                break;
        }
        m_bubbleTxt.text = message;
        m_bubbleImage.enabled = true;
    }
}
