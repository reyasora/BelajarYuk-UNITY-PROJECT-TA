using NUnit.Framework;
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;
using System.Collections;

public class CardsController : MonoBehaviour
{
    [SerializeField] Card cardPrefab;
    [SerializeField] Transform gridTransform;
    [SerializeField] Sprite[] sprites;

    private List<Sprite> spritePairs;

    Card firstSelected;
    Card secondSelected;
    //int jumlahKartu;

    private void Start()
    {
        PrepareSprite();
        CreateCards();
    }

    private void PrepareSprite()
    {
        spritePairs = new List<Sprite>();
        for (int i = 0; i < sprites.Length; i++)
        {
            spritePairs.Add(sprites[i]);
            spritePairs.Add(sprites[i]);
        }
        ShuffleSprites(spritePairs);
        //jumlahKartu = spritePairs.Count;
        //Debug.Log("Total Cards: " + spritePairs.Count);
    }

    void CreateCards()
    {
        for (int i = 0; i < spritePairs.Count; i++)
        {
            Card card = Instantiate(cardPrefab, gridTransform);
            card.SetIconSprite(spritePairs[i]);
            card.controller = this;
        }
    }

    public void SetSelected(Card card)
    {
        if (!card.isSelected)
        {
            card.Show();

            if (firstSelected == null)
            {
                firstSelected = card;
                return;
            }

            if (secondSelected == null)
            {
                secondSelected = card;
                StartCoroutine(CheckMatching(firstSelected, secondSelected));
                firstSelected = null;
                secondSelected = null;
            }
        }
    }

    IEnumerator CheckMatching(Card a, Card b)
    {
        yield return new WaitForSeconds(0.3f);
        if (a.iconSprite == b.iconSprite)
        {
            //match
            //jumlahKartu -= 2;
        }
        else
        {
            //flip card
            a.Hide();
            b.Hide();
        }
    }

    void ShuffleSprites(List<Sprite> spriteList)
    {
        for (int i = spriteList.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            Sprite temp = spriteList[i];
            spriteList[i] = spriteList[randomIndex];
            spriteList[randomIndex] = temp;
        }
    }
}
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class CardsController : MonoBehaviour
//{
//    [SerializeField] private Card cardPrefab;
//    [SerializeField] private Transform gridTransform;
//    [SerializeField] private Sprite[] sprites;
//    [SerializeField] private Button winButton; // 🎯 button shown when all cards are matched

//    private List<Sprite> spritePairs;
//    private Card firstSelected;
//    private Card secondSelected;

//    private int totalPairs;
//    private int matchedPairs = 0;

//    private void Start()
//    {
//        winButton.gameObject.SetActive(false); // Hide button at start
//        PrepareSprite();
//        CreateCards();
//    }

//    private void PrepareSprite()
//    {
//        spritePairs = new List<Sprite>();
//        for (int i = 0; i < sprites.Length; i++)
//        {
//            spritePairs.Add(sprites[i]);
//            spritePairs.Add(sprites[i]);
//        }

//        totalPairs = sprites.Length; // each sprite makes one pair
//        ShuffleSprites(spritePairs);
//    }

//    private void CreateCards()
//    {
//        for (int i = 0; i < spritePairs.Count; i++)
//        {
//            Card card = Instantiate(cardPrefab, gridTransform);
//            card.SetIconSprite(spritePairs[i]);
//            card.controller = this;
//        }
//    }

//    public void SetSelected(Card card)
//    {
//        if (card.isSelected) return;

//        if (firstSelected == null)
//        {
//            firstSelected = card;
//            firstSelected.Show();
//            return;
//        }

//        if (secondSelected == null)
//        {
//            secondSelected = card;
//            secondSelected.Show();

//            CheckMatching(firstSelected, secondSelected);
//            firstSelected = null;
//            secondSelected = null;
//        }
//    }

//    private void CheckMatching(Card a, Card b)
//    {
//        if (a.iconSprite == b.iconSprite)
//        {
//            //Match found
//            matchedPairs++;

//            // Optionally disable the matched cards so they can't be clicked again
//            a.gameObject.SetActive(false);
//            b.gameObject.SetActive(false);

//            //All pairs matched
//            if (matchedPairs >= totalPairs)
//            {
//                ShowWinButton();
//            }
//        }
//        else
//        {
//            // Not a match — flip back after short delay
//            StartCoroutine(FlipBackAfterDelay(a, b, 0.5f));
//        }
//    }

//    private System.Collections.IEnumerator FlipBackAfterDelay(Card a, Card b, float delay)
//    {
//        yield return new WaitForSeconds(delay);
//        a.Hide();
//        b.Hide();
//    }

//    private void ShowWinButton()
//    {
//        winButton.gameObject.SetActive(true);
//    }

//    private void ShuffleSprites(List<Sprite> spriteList)
//    {
//        for (int i = spriteList.Count - 1; i > 0; i--)
//        {
//            int randomIndex = Random.Range(0, i + 1);
//            Sprite temp = spriteList[i];
//            spriteList[i] = spriteList[randomIndex];
//            spriteList[randomIndex] = temp;
//        }
//    }
//}
